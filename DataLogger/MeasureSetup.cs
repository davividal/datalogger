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
    public partial class MeasureSetup : Form
    {
        public MeasureSetup()
        {
            InitializeComponent();
        }

        private void MeasureSetup_Load(object sender, EventArgs e)
        {
            IntervalItem hours = new IntervalItem("horas", 3600000, "h");
            IntervalItem minutes = new IntervalItem("minutos", 60000, "min");
            IntervalItem seconds = new IntervalItem("segundos", 1000, "s");
            IntervalItem miliseconds = new IntervalItem("milisegundos", 1, "ms");

            intervalBox.Items.Add(hours);
            intervalBox.Items.Add(minutes);
            intervalBox.Items.Add(seconds);
            intervalBox.Items.Add(miliseconds);

            intervalBox.SelectedIndex = 1;
        }

        public int getValue()
        {
            try
            {
                return Convert.ToInt32(measureText.Text) * ((IntervalItem)intervalBox.SelectedItem).Value;
            }
            catch (System.FormatException)
            {
                return 0;
            }
        }

        public string getTime()
        {
            return String.Format("{0} {1}", measureText.Text, ((IntervalItem)intervalBox.SelectedItem).Unit);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
