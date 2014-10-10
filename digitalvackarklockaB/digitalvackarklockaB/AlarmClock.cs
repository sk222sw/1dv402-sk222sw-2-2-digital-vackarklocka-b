using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalvackarklockaB
{
    public class AlarmClock
    {
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;
        AlarmClock ac = new AlarmClock();

        public int AlarmHour
        {
            get { return _alarmHour; }
            set { _alarmHour = value; }
        }

        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set { _alarmMinute = value; }
        }

        public int Hour
        {
            get { return _hour; }
            set { _hour = value; }
        }

        public int Minute
        {
            get { return _minute; }
            set { _minute = value; }
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
