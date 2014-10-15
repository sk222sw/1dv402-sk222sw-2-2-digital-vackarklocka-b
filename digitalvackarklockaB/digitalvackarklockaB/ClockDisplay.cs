using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalvackarklockaB
{
    public class ClockDisplay 
    {
        private NumberDisplay _hourDisplay;         //Klar
        private NumberDisplay _minuteDisplay;         //Klar
        
        public int Hour
        {
            get { return _hourDisplay.Number; }
            set { _hourDisplay.Number = value; }
        }                            //Klar
        public int Minute
        {
            get { return _minuteDisplay.Number; }
            set { _minuteDisplay.Number = value; }
        }                           //Klar

        public ClockDisplay()                        //Klar
            :this (0, 0)
        {

        }

        public ClockDisplay(int hour, int minute)         //Klar kanske? varför?
        {
            _hourDisplay = new NumberDisplay(24, hour);
            _minuteDisplay = new NumberDisplay(60, minute);
        }


        public void Increment()                         //Klar
        {
            _minuteDisplay.Increment();
            if (Minute == 0)
            {
                _hourDisplay.Increment();
            }
        }

        public override string ToString()
        {
            return String.Format(" {0}:{1:D2}", Hour, Minute);  
        }
    }
}
