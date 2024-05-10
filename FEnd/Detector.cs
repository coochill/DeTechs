using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace FEnd
{
   
    public partial class Detector : UserControl
    {
        private SerialPort _serialPort;
        EarthquakeHistoryDAO ehd = new EarthquakeHistoryDAO();
        BindingSource bs = new BindingSource();
        public Detector()
        {
            InitializeComponent();
            _serialPort = new SerialPort("COM4", 9600);
            _serialPort.DataReceived += SerialPort_DataReceived;
            try
            {
                // Open the serial port
                _serialPort.Open();

                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();

                // Close the serial port when done
                _serialPort.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Read the data from the serial port
            string data = _serialPort.ReadLine(); // ReadLine() will read until a newline character is received
            string x = "";
            // Print the received data
            if (data.Contains("Dangerous:"))
            {
                x = "Dangerous:";
                int index = data.IndexOf(x);

                add(int.Parse(data.Substring(0, index) + data.Substring(index + x.Length)));
            }
            else if (data.Contains("High:"))
            {
                x = "High:";
                int index = data.IndexOf(x);

                add(int.Parse(data.Substring(0, index) + data.Substring(index + x.Length)));
            }
            else if (data.Contains("Mild:"))
            {
                x = "Mild:";
                int index = data.IndexOf(x);

                add(int.Parse(data.Substring(0, index) + data.Substring(index + x.Length)));
            }
            else if (data.Contains("Low"))
            {
                x = "Low";
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FNStart_Click(object sender, EventArgs e)
        {

        }

        private void Detector_Load(object sender, EventArgs e)
        {
           
            bs.DataSource = ehd.GetHistory();
            HistoryGrid.DataSource = bs;
            //connecting list to the view grid control view
        }

        private void add(int intensity)
        {
            DateTime currentDate = DateTime.Now;
            string Date = currentDate.ToString("yyyy-MM-dd");
            string Time = currentDate.ToString("HH:mm:ss");

            // Add data to history
            ehd.AddToHistory(bs, Date, Time, intensity);

            // Ensure bs.DataSource is not null before setting it to the data source
            if (bs.DataSource == null)
            {
                bs.DataSource = new List<EQHistory>(); // Create an empty list if bs.DataSource is null
            }

            // Update UI controls on the UI thread
            this.Invoke((MethodInvoker)delegate {
                // Refresh the data source bound to HistoryGrid
                bs.ResetBindings(false); // ResetBindings to update the grid
                HistoryGrid.DataSource = bs;
            });
        }
    }
}
