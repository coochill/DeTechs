using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEnd
{
    public partial class Form1 : Form
    {
        private WeatherForecast weatherForecast;
        private EDetector detectorE;

        public Form1()
        {
            InitializeComponent();
            weatherForecast = new WeatherForecast();
            detectorE = new EDetector();
            addUserControl(weatherForecast); 
           
        }

        private void addUserControl(UserControl userControl)
        {
            //userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            panel1.BringToFront();
        }

        private void Weatherbtn_Click(object sender, EventArgs e)
        {
            addUserControl(weatherForecast); // Show weather forecast control
        }

        private void Earthquakebtn_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addUserControl(detectorE);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
