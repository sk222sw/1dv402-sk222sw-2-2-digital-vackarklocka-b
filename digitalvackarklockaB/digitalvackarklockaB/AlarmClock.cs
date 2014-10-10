using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalvackarklockaB
{
    public class AlarmClock
    {
        private ClockDisplay _alarmTime;
        private ClockDisplay _time;

        public int AlarmHour
        {
            get { return _alarmTime.Hour; }
            set { _alarmTime.Hour = value; }
        }

        public int AlarmMinute
        {
            get { return _alarmTime.Minute; }
            set { _alarmTime.Minute = value; }
        }

        public int Hour
        {
            get { return _time.Hour; }
            set { _time.Hour= value; }
        }

        public int Minute
        {
            get { return _time.Minute; }
            set { _time.Minute = value; }
        }

        public AlarmClock()
            : this(0, 0)
        { }

        public AlarmClock(int hour, int minute)
            : this(hour, minute, 0, 0)
        { }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
            
        }

        public bool TickTock()          //Hämtar Increment() och kollar om alarmet stämmer
        {
            AlarmClock ac = new AlarmClock(1, 12);
            //if (Hour == AlarmHour && Minute == AlarmMinute)     
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        return false;
        }

        public string ToString()
        {
            string hej = "hej";
            return hej;
        }

    }
}
