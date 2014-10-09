using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogger
{
    class IntervalItem
    {
        public string Text { get; set; }
        public int Value { get; set; }
        public string Unit { get; set; }

        public IntervalItem(string text, int value, string unit)
        {
            this.Text = text;
            this.Value = value;
            this.Unit = unit;
        }

        public override string ToString()
        {
            return this.Text;
        }
    }
}
