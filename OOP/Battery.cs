using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batteryType;

        public Battery() : this(null) 
        {
        }

        public Battery(string model)
            : this(model,0,0)
        {
        }

        public Battery(string model,int hoursIdle, int hoursTalk)
            : this(model, hoursIdle, hoursTalk,0)
        {
        }

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType batteryType) 
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }

        public string Model 
        {
            get 
            {
                return this.model;
            }

            set 
            {
                this.model = value;
            }
        }

        public int HoursIdle
        {
            get 
            {
                return this.hoursIdle;
            }
            set 
            {
                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get 
            {
                return this.hoursTalk;
            }
            set 
            {
                this.hoursTalk = value;
            }
        }

        public override string ToString()
        {
            return string.Format("\nModel battery: {0}\nHours stendby: {1}\nHours talk: {2}\nBattery type: {3}", 
                this.model ?? "[none]", this.hoursIdle, this.hoursTalk, this.batteryType);
        }

    }
}
