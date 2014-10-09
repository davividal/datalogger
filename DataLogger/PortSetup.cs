using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLogger
{
    public partial class PortSetup : Form
    {
        public PortSetup()
        {
            InitializeComponent();
        }

        public String getPort()
        {
            return this.portName.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
