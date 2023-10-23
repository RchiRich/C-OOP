using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace C_OOP
{
    internal class Timer
    {
        private int RemainingSeconds { get; set; }

       
        public Timer(int seconds)
        {
            RemainingSeconds = seconds;
        }

        public void SetTime(int seconds)
        {
            RemainingSeconds = seconds;
        }

        public void StartTimer()
        {
            while (RemainingSeconds > 0)
            {
                Console.WriteLine($"Hátralévő idő: {RemainingSeconds} másodperc");
                Thread.Sleep(1000); // 1 másodperc várakozás
                RemainingSeconds--;
            }
            Console.WriteLine("Az időzítő lejárt!");

        }  
    }
}
