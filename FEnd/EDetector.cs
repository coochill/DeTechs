using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEnd
{
    public partial class EDetector : UserControl
    {
        private SerialPort _serialPort;
        EarthquakeHistoryDAO ehd = new EarthquakeHistoryDAO();
        BindingSource bs = new BindingSource();
        public EDetector()
        {
            InitializeComponent();
            _serialPort = new SerialPort("COM4", 9600);
            _serialPort.DataReceived += SerialPort_DataReceived;
            //_serialPort.Close();
            // Open the serial port
            _serialPort.Open();
                // Close the serial port when done
               
           
            
        }
        bool warning = false;
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Read the data from the serial port
            string data = _serialPort.ReadLine(); // ReadLine() will read until a newline character is received
            string x = "";
            // Print the received data
            if (data.Contains("Dangerous:")&&!warning)
            {
                x = "Dangerous:";
                warning = true;
                int index = data.IndexOf(x);

                add(int.Parse(data.Substring(0, index) + data.Substring(index + x.Length)));
                MessageBox.Show("Detected: Dangerous level earthquake!", "Earthquake Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (data.Contains("High:") && !warning)
            {
                x = "High:";
                warning = true;
                int index = data.IndexOf(x);

                add(int.Parse(data.Substring(0, index) + data.Substring(index + x.Length)));
                MessageBox.Show("Detected: High level earthquake!", "Earthquake Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (data.Contains("Mild:") && !warning)
            {
                x = "Mild:";
                warning = true;
                int index = data.IndexOf(x);

                add(int.Parse(data.Substring(0, index) + data.Substring(index + x.Length)));
                MessageBox.Show("Detected: Mild level earthquake!", "Earthquake Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (data.Contains("Low"))
            {
                warning = false;
                x = "Low";
                int index = data.IndexOf(x);

            }
            else if (data.Contains("Fire"))
            {
                x = "Fire Detected!";
                

                
                MessageBox.Show("Detected: Nerby Fire Detected", "Fire Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

                // Check if the handle has been created before accessing UI elements
                if (this.IsHandleCreated)
            {
                // Invoke the UI update on the UI thread
                this.Invoke((MethodInvoker)delegate {
                    Level.Text = x;
                    
                    int place = data.IndexOf(x);
                    string txt = data.Substring(0, place) + data.Substring(place + x.Length);
                    IntensityTXT.Text = txt;
                });
            }
        }

        private void EDetector_Load(object sender, EventArgs e)
        {
            bs.DataSource = ehd.GetHistory();
            HistoryGrid.DataSource = bs;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
                bs.DataSource = ehd.GetHistory();
                HistoryGrid.DataSource = bs;
            });
        }
    }
}
