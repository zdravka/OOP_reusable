using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Display
    {
        protected double size { get; set; }
        protected string numColors { get; set; }

        public Display() : this(0, null) 
        {
        }

        public Display(double size, string numColors)
        {
            this.size = size;
            this.numColors = numColors;
        }

        public override string ToString()
        {
            return string.Format("\nNumber of colors: {0} \nDisplay size: {1}", this.numColors ?? "[none]", this.size);
        }
    }
}
