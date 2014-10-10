using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalvackarklockaB
{
    public class ClockDisplay 
    {
        private NumberDisplay _hourDisplay;
        private NumberDisplay _minuteDisplay;
        
        public int Hour
        {
            get { return _hourDisplay.Number; }
            set { _hourDisplay.Number = value; }
        }
        public int Minute
        {
            get { return _minuteDisplay.Number; }
            set { _minuteDisplay.Number = value; }
        }

        public ClockDisplay()
        {

        }

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
