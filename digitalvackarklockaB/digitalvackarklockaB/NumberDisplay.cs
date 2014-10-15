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
                if (value > 0)
                {
                    _maxNumber = value;
                }
                else
                {
                    throw new ArgumentException("MaxNumber får inte vara mindre än 0");
                }
            }
        }           //Klar

        public int Number
        {
            get { return _number; }
            set
            {
                if (_number >= 1 || _number < MaxNumber)
                {
                    _number = value;
                }
                else
                {
                    throw new ArgumentException("Number får inte vara 0 eller högre än MaxNumber");
                }
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
            Number++;
            if (Number == MaxNumber)
            {
                Number = 0;
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
