using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalvackarklockaB
{
    class NumberDisplay                 //Klar förutom den sista ToString som är förvirrande just nu.
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

        //Konstruktorer:
        public NumberDisplay(int maxNumber)
            :this (maxNumber, 0)
        {
        }

        public NumberDisplay (int maxNumber, int number)
	    {
            MaxNumber = number;
            Number = number;    
	    }


        //Metoder

        public void Increment()         //byta ut _number och _mxnumber till Number och MaxNumber?
        {
            _number++;
            if (_number == _maxNumber)
            {
                _number = 0;
            }
        }

        public override string ToString()
        {
            return string.Format("{0:D2}", Number);
        }


        public string ToString(string format)
        {
            format = "format";
            return format;
        }

    }
}
