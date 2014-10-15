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

        public int MaxNumber        //Kapslar in fältet _maxNumber
        {
            get { return _maxNumber; }
            set  
            {
                if (value < 0)
                {
                    throw new ArgumentException("Maxvärdet måste vara större än 0.");
                }
                _maxNumber = value;
            }
        }          

        public int Number       //Kapslar in fältet _number
        {
            get { return _number; }
            set
            {
                if (value < 0 || value > MaxNumber)
                {
                    throw new ArgumentException(String.Format("Värdet är inte i intervallet 0-{0}.", _maxNumber));
                }
                _number = value;
            }
        }          

        //Konstruktorer:
        public NumberDisplay(int maxNumber)     //Konstruktor som ärver från huvudkonstruktorn
            :this (maxNumber, 0)
        {
        }

        public NumberDisplay (int maxNumber, int number)        //Huvudkonstruktor
	    {
            MaxNumber = maxNumber;
            Number = number;    
	    }       


        //Metoder

        public void Increment()         //byta ut _number och _mxnumber till Number och MaxNumber? Nej
        {
            if (_number < _maxNumber)
            {
                _number++;
            }
            else
            {
                _number = 0;
            }
        }

        public override string ToString()
        {
            return ToString("G");
        }


        public string ToString(string format)      
        {
            if (format == "0" || format == "G")
            {
                return string.Format("{0}", Number);
            }
            else if (format == "00")
            {
                return string.Format("{0:D2}", Number);
            }
            throw new FormatException();
        }

    }
}
