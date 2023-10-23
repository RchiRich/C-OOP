using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP
{
    internal class Clock
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public string TimeZone { get; set; }
        public bool Is24HourFormat { get; set; }
        public Clock(int hour, int minute, int second, string timeZone, bool is24HourFormat)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
            TimeZone = timeZone;
            Is24HourFormat = is24HourFormat;
        }
        public void SetTime(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        public void DisplayTime()
        {
            string timeFormat = Is24HourFormat ? "24 órás" : "12 órás";
            string amPm = Is24HourFormat ? "" : (Hour >= 12 ? "PM" : "AM");
            Console.WriteLine($"{Hour:D2}:{Minute:D2}:{Second:D2} {amPm} {timeFormat} {Is24HourFormat}");
        }
        public void SetTimeZone(string timeZone)
        {
            TimeZone = timeZone;
        }
        public void ToggletTimeFormat()
        {
            Is24HourFormat = !Is24HourFormat;
        }
    }
}
