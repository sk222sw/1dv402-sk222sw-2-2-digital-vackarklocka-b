using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalvackarklockaB
{
    class NumberDisplay
    {
        private int _maxNumber;
        private int _number;

        public int MaxNumber
        {
            get { return _maxNumber; }
            set 
            {
                if (_maxNumber < 1)
                {
                    throw new ArgumentException("MaxNumber får inte vara större än 0");
                }
                _maxNumber = value; 
            }
        }

        public int Number
        {
            get { return _number; }
            set
            {
                if (_number < 1 || _number > MaxNumber)
                {
                    throw new ArgumentException("Number får inte vara 0 eller högre än MaxNumber");
                }
                _number = value; 
            }
        }

        
    }
}
