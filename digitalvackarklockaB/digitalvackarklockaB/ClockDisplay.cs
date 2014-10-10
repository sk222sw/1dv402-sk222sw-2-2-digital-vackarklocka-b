using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalvackarklockaB
{
    public class ClockDisplay : AlarmClock
    {
        private int _hourDisplay;
        private int _minuteDisplay;

        public ClockDisplay()
        {}

        public ClockDisplay(int hour, int minute)
        {
            
        }

        public void Increment()
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
        }
    }
}
