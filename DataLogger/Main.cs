using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

using Microsoft.VisualBasic;

namespace DataLogger
{
    public partial class Main : Form
    {
        private string fileName = null;

        private Boolean running = false;

        private int counter = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void portMenu_Click(object sender, EventArgs e)
        {
            ((ToolStripDropDownButton)sender).DropDownItems.Clear();
            foreach (string port in SerialPort.GetPortNames())
            {
                ((ToolStripDropDownButton)sender).DropDownItems.Add(port);
            }
            ((ToolStripDropDownButton)sender).DropDownItems.Add("foo");
            ((ToolStripDropDownButton)sender).DropDownItems.Add("foo");
        }

        private void timeInterval_Click(object sender, EventArgs e)
        {
            IntervalSetup intervalSetup = new IntervalSetup();

            intervalSetup.ShowDialog();

            if (0 < intervalSetup.getValue())
            {
                ((ToolStripDropDownButton)sender).Text = intervalSetup.getTime();

                intervalTimer.Interval = intervalSetup.getValue();
            }
        }

        private void measureTime_Click(object sender, EventArgs e)
        {
            MeasureSetup measureSetup = new MeasureSetup();

            measureSetup.ShowDialog();

            if (0 < measureSetup.getValue())
            {
                ((ToolStripDropDownButton)sender).Text = measureSetup.getTime();

                measureTimer.Interval = measureSetup.getValue();
            }
        }

        private void startProcess_Click(object sender, EventArgs e)
        {
            if (!this.running)
            {
                if (this.fileName == null || this.fileName.Length <= 0)
                {
                    saveFileDialog1.ShowDialog();
                }

                if (this.fileName == null || this.fileName.Length <= 0)
                {
                    return;
                }
            }

            toogleMeasure();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.fileName = saveFileDialog1.FileName;
        }

        private void intervalTimer_Tick(object sender, EventArgs e)
        {
            string time = Convert.ToString(DateTime.Now.TimeOfDay);
            collectedData.AppendText(time + ";Medida " + Convert.ToString(this.counter++) + "\r\n");
        }

        private void measureTimer_Tick(object sender, EventArgs e)
        {
            toogleMeasure();
        }

        private void toogleMeasure()
        {
            String imageKey, text;

            if (this.running)
            {
                imageKey = "start-icon 16.png";
                text = "Iniciar";
            }
            else
            {
                imageKey = "stop-icon.png";
                text = "Parar";
            }

            startProcess.ImageKey = imageKey;
            startProcess.Text = text;

            intervalTimer.Enabled = measureTimer.Enabled = this.running = !this.running;
        }
    }
}
