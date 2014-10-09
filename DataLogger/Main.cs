using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace DataLogger
{
    public partial class Main : Form
    {
        private string fileName = null;

        private Boolean running = false;

        public Main()
        {
            InitializeComponent();
        }

        private void portMenu_Click(object sender, EventArgs e)
        {
            PortSetup portSetup = new PortSetup();

            portSetup.ShowDialog();

            string port = portSetup.getPort();

            if (0 < port.Trim().Length)
            {
                ((ToolStripDropDownButton)sender).Text = port;

                serialPort1.PortName = port;
            }
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

                ((Button)sender).ImageKey = "stop-icon.png";
                ((Button)sender).Text = "Parar";
            }
            else
            {
                ((Button)sender).ImageKey = "start-icon 16.png";
                ((Button)sender).Text = "Iniciar";
            }

            this.running = !this.running;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.fileName = saveFileDialog1.FileName;
        }
    }
}
