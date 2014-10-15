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

        private Boolean intervalSetup = false;

        private Boolean measureSetup = false;

        private int counter = 0;

        public Main()
        {
            InitializeComponent();
        }

        public Boolean setup()
        {
            return this.intervalSetup && this.measureSetup;
        }

        private void portMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem portMenu = new ToolStripMenuItem();

            ((ToolStripDropDownButton)sender).DropDownItems.Clear();
            foreach (string portName in SerialPort.GetPortNames())
            {
                portMenu = new ToolStripMenuItem();
                portMenu.Text = portName;
                portMenu.Click += setupPortClick;

                ((ToolStripDropDownButton)sender).DropDownItems.Add(portMenu);
            }

            portMenu = new ToolStripMenuItem();
            portMenu.Text = "COM1";
            portMenu.Click += setupPortClick;
            ((ToolStripDropDownButton)sender).DropDownItems.Add(portMenu);

            portMenu = new ToolStripMenuItem();
            portMenu.Text = "COM2";
            portMenu.Click += setupPortClick;
            ((ToolStripDropDownButton)sender).DropDownItems.Add(portMenu);
        }

        private void setupPortClick(object sender, EventArgs e)
        {
            serialPort1.PortName = ((ToolStripMenuItem)sender).Text;
        }

        private void timeInterval_Click(object sender, EventArgs e)
        {
            IntervalSetup intervalSetup = new IntervalSetup();

            intervalSetup.ShowDialog();

            if (0 < intervalSetup.getValue())
            {
                ((ToolStripDropDownButton)sender).Text = intervalSetup.getTime();

                intervalTimer.Interval = intervalSetup.getValue();
                this.intervalSetup = true;
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
                this.measureSetup = true;
            }
        }

        private void startProcess_Click(object sender, EventArgs e)
        {
            if (!this.setup())
            {
                measureTime_Click(measureTime, EventArgs.Empty);
                timeInterval_Click(timeInterval, EventArgs.Empty);

                if (!this.setup())
                {
                    MessageBox.Show(
                        "Você não configurou os intervalos de medição!", 
                        "Impossível Medir", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Stop
                    );

                    return;
                }
            }

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
            String measure;

            try
            {
                measure = serialPort1.ReadLine();

                collectedData.AppendText(time + ";" + measure + "\r\n");
            }
            catch (System.InvalidOperationException exception)
            {
                toogleMeasure();

                MessageBox.Show(
                    "Ocorreu um erro durante a leitura da porta serial. A mensagem de erro foi: " + exception.Message,
                    "Impossível Medir",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                );
            }
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
