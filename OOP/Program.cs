using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Battery battery = new Battery();
            battery.Model = "model battery";
            battery.HoursIdle = 15;
            battery.HoursTalk = 7;

            Display display = new Display(4.2, "16M");

            //Battery battery1 = new Battery("model battery 2", 15, 7);
            //Battery battery2 = new Battery("model battery 2", 15, 7,BatteryType.LiIon);
            //Display display1 = new Display(4.2, "16M 2");

            //GSM gsm = new GSM("galaxy","samsung",196,"zdravka");
           
            //GSM gsm1 = new GSM("modelTEST","manufacturerTEST", 5000, "ownerTEST",battery, display1);
            
            //GSM gsm2 = new GSM("modelTEST","manufacturerTEST");
            
            
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            //Console.WriteLine(gsm);
            //Console.ResetColor();
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.WriteLine(gsm1);
            //Console.ResetColor();
            //Console.WriteLine(gsm2);
            


        }
    }
}
