using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalvackarklockaB
{
    class AlarmClock
    {
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;

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

        public bool TickTock()          //Metod som får klockan att gå en minut.
        {

            if (Minute == 59)           //Ser till att tiden aldrig går över 23 för timmar, och 59 för minuter.
            {
                Minute = 0;

                if (Hour == 23)
                {
                    Hour = 0;
                }
            }
            Minute++;

            if (Hour == AlarmHour && Minute == AlarmMinute)     //Får alarmet att gå igång om när klockan når alarmtiden. 
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
