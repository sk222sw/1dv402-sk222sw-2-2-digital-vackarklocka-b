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
            set { _time.Hour = value; }
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
            _time = new ClockDisplay(hour, minute);
            _alarmTime = new ClockDisplay(alarmHour, alarmMinute);
        }

        public bool TickTock()          //Hämtar Increment() och kollar om alarmet stämmer
        {
            _time.Increment();
            if (Hour == AlarmHour && Minute == AlarmMinute)     
            {
                return true;
            }
                return false;
        }

        public override string ToString()           //Metod som formaterar tid och alarm till en sträng.
        {
                return string.Format("{0} ({1})", _time, _alarmTime);  
        }

    }
}
