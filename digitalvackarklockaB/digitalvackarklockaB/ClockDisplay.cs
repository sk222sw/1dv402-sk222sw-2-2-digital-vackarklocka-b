using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalvackarklockaB
{
    public class ClockDisplay 
    {
        private NumberDisplay _hourDisplay;         //Aggregatfält som hämtar från numberdisplay
        private NumberDisplay _minuteDisplay;         //Aggregatfält som hämtar från numberdisplay
        
        public int Hour         // kapslar in _hourDisplay
        {
            get { return _hourDisplay.Number; }
            set { _hourDisplay.Number = value; }
        }                      

        public int Minute           //Kapslar in _minuteDisplay
        {
            get { return _minuteDisplay.Number; }
            set { _minuteDisplay.Number = value; }
        }                           //Klar

        public ClockDisplay()                        //Ärver från huvudkonstruktorn
            :this (0, 0)
        {

        }

        public ClockDisplay(int hour, int minute)         //Huvudkonstruktorn, instansierar aggregatfälten som objekt av NumberDisplay
        {
            _hourDisplay = new NumberDisplay(23, hour);
            _minuteDisplay = new NumberDisplay(59, minute);
        }


        public void Increment()                         //Hämtar Increment från NumberDisplay via aggregatfälten och sätter tiden till noll ifall klockan är MaxNumber 
        {
            _minuteDisplay.Increment();
            if (_minuteDisplay.Number == 0)
            {
                _hourDisplay.Increment();
            }

        }

        public override string ToString()
        {
            return String.Format("{0,2}:{1}", _hourDisplay.ToString(), _minuteDisplay.ToString("00"));  
        }
    }
}
