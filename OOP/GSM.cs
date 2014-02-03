using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class GSM
    {
        private string model { get; set; }
        private string manufacturer { get; set; }
        private decimal price { get; set; }
        private string owner { get; set; }
        private Battery battery;
        private Display display;
        private static GSM iphone4S;

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0, null)
        {
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price, owner, null, null)
        {
        }

        public GSM(string model, string manufacturer, decimal price, string owner,Battery battery, Display display)
        {
            this.battery = battery;
            this.display = display;
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }

        public string IPhone4S
        {
            get
            {
                this.display = new Display(3.5, "16M");
                this.battery = new Battery(null, 9, 200, BatteryType.LiIon);
                iphone4S = new GSM("IPhone4S", "Apple", 745, "zdravka", battery, display);
                return iphone4S.ToString();
            }
        }

        public override string ToString()
        {
            return string.Format("model: {0}\nmanufacturer: {1}\nprice: {2}\nowner: {3}\nbattery: {4}\ndisplay: {5}\n",
                this.model ?? "[none]",this.manufacturer ?? "[none]",this.price, this.owner ?? "[none]", this.battery, this.display);
        }
       

    }
}
