using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalvackarklockaB
{
    public class AlarmClock
    {
        private ClockDisplay _alarmTime;        //Aggregatfält som hämtar från clockdisplay
        private ClockDisplay _time;             //Aggregatfält som hämtar från clockdisplay

        public int AlarmHour
        {
            get { return _alarmTime.Hour; }
            set { _alarmTime.Hour = value; }
        }                   //kapslar in _alarmTime.Hour

        public int AlarmMinute
        {
            get { return _alarmTime.Minute; }
            set { _alarmTime.Minute = value; }
        }                   //kapslar in _alarmMInute.Minute

        public int Hour                         //kapslar in _time.Hour
        {
            get { return _time.Hour; }
            set { _time.Hour = value; }
        }                       

        public int Minute
        {
            get { return _time.Minute; }
            set { _time.Minute = value; }
        }               //Kapslar in _time.Minute

        public AlarmClock()                 //Ärver från konstruktorn med två parametrar
            : this(0, 0)
        { }

        public AlarmClock(int hour, int minute)         //Ärver från huvudkonsturktorn
            : this(hour, minute, 0, 0)
        { }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)             //Huvudkonstruktor som tilldelar _time och _alarmTime till ClockDisplay-objekt
        {
            _time = new ClockDisplay(hour, minute);
            _alarmTime = new ClockDisplay(alarmHour, alarmMinute);
        }

        public bool TickTock()          //Hämtar Increment() och kollar om alarmet stämmer
        {
            _time.Increment();
            return Hour == AlarmHour && Minute == AlarmMinute;
        }

        public override string ToString()           //Metod som formaterar tid och alarm till en sträng.
        {
                return string.Format("{0} ({1})", _time, _alarmTime);  
        }

    }
}
