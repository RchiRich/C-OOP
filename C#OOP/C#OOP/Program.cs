using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock(12, 30, 45, "UTC+2", true);

            List<Alarm> alarms = new List<Alarm>();
            alarms.Add(new Alarm(6, 0));
            alarms.Add(new Alarm(8, 0));

            Timer myTimer = new Timer(10);

            myClock.DisplayTime();

            foreach (var alarm in alarms)
            {
                if (alarm.IsAlarmTime(myClock.Hour, myClock.Minute))
                {
                    Console.WriteLine("Az ébresztő megszólalt!");
                }
            }
                     
            myTimer.StartTimer();

            Console.WriteLine("Az időzítő lejárt!");
        }
    }
}