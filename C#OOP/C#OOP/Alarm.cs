using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP
{
    internal class Alarm
    {
        public int AlarmHour {  get; set; }
        public int AlarmMinute { get; set; }
        public bool IsAlarmOn { get; set; }

        public Alarm(int hour,int minute)
        {
            AlarmHour = hour;
            AlarmMinute = minute;
            IsAlarmOn = false;
        }
        public void SetAlarm(int hour,int minute)
        {
            AlarmHour = hour;
            AlarmMinute = minute;
        }
        public void TurnOnAlarm()
        {
            IsAlarmOn = true;
        }
        public void TurnOffAlarm()
        {
            IsAlarmOn = false;
        }
        public bool IsAlarmTime(int chour,int cminute)
        {
            return chour == AlarmHour && cminute == AlarmMinute;
        }
        
    }
    
}
