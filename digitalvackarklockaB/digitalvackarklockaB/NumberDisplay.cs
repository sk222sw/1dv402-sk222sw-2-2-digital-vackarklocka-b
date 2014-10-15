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
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _maxNumber = value;
            }
        }           //Klar

        public int Number
        {
            get { return _number; }
            set
            {
                if (value < 0 || value > MaxNumber)
                {
                    throw new ArgumentException();
                }
                _number = value;
            }
        }               //Klar

        //Konstruktorer:
        public NumberDisplay(int maxNumber)     //klar
            :this (maxNumber, 0)
        {
        }

        public NumberDisplay (int maxNumber, int number)
	    {
            MaxNumber = maxNumber;
            Number = number;    
	    }       //klar


        //Metoder

        public void Increment()         //byta ut _number och _mxnumber till Number och MaxNumber? Nej
        {
            _number++;
            if (_number == _maxNumber)
            {
                _number = 0;
                return;
            }
        }

        public override string ToString()
        {
            return string.Format("{0:D2}", Number);
        }


        public string ToString(string format)      //Klar tror jag men vad ska man med den till!?
        {
            if (format == "0" || format == "G")
            {
                return string.Format("{0:D}", Number);
            }
            throw new FormatException();
        }

    }
}
