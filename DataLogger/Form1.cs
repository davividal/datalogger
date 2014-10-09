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
        private string fileName;

        public Main()
        {
            InitializeComponent();
        }

        private void portMenu_Click(object sender, EventArgs e)
        {
            string port = Interaction.InputBox(
                "Qual porta deseja usar?", 
                "Configurar Porta", 
                "COM5"
            );

            if (0 < port.Trim().Length)
            {
                ((ToolStripDropDownButton)sender).Text = port;

                serialPort1.PortName = port;
            }
        }

        private void timeInterval_Click(object sender, EventArgs e)
        {
            string interval = Interaction.InputBox(
                "Quanto tempo irá durar a medição (em minutos)?", 
                "Configurar Medição", 
                "60"
            );

            if (0 < interval.Trim().Length)
            {
                ((ToolStripDropDownButton)sender).Text = interval + " min";

                measureTimer.Interval = Convert.ToInt32(interval) * 6000;
            }
        }

        private void measureTime_Click(object sender, EventArgs e)
        {
            string interval = Interaction.InputBox(
                "Qual o intervalo de tempo entre as medições (em segundos)?",
                "Configurar Medição",
                "15"
            );

            if (0 < interval.Trim().Length)
            {
                ((ToolStripDropDownButton)sender).Text = interval + " s";

                measureTimer.Interval = Convert.ToInt32(interval) * 1000;
            }
        }

        private void startProcess_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.fileName = saveFileDialog1.FileName;
        }
    }
}
