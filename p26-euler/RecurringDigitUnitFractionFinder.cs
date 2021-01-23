using System;
using System.Collections.Generic;
using System.Text;

namespace p26_euler
{
    public class RecurringDigitUnitFractionFinder
    {


        private UnitFractionDecimalRepresentation ufdr;

        private bool IsValidIndex(int index)
        {
            return index != -1;
        }

        private bool IndexIsNotTheSameAsCurrent(int index)
        {
            return index != ufdr.Remainders.Count - 1;
        }

        private bool MaxCountReached()
        {
            return ufdr.Remainders.Count == ufdr.Denominator;
        }

        private bool MightBeRecuringCycleNumber()
        {
            return ufdr.LastRemainder() != 0;
        }


        public int Denominator { 
            get
            {
                return ufdr.Denominator;
            }

            set
            {
                ufdr.Denominator = value;
            }
        }

        public RecurringDigitUnitFractionFinder(int denom)
        {

            ufdr = new UnitFractionDecimalRepresentation(denom);
            Denominator = denom;
        }   


        


        public int GetRecuringCycleCount()
        {

            while(MightBeRecuringCycleNumber())
            {
                ufdr.GetNextDigit();
                int currRemainder = ufdr.LastRemainder();
                int index = ufdr.Remainders.IndexOf(currRemainder);

                if (IsValidIndex(index) && IndexIsNotTheSameAsCurrent(index))
                {
                    return (ufdr.Remainders.Count - 1) - index;
                }

                if (MaxCountReached())
                {
                    break;
                }

            }

            return 0;
        }


    }
}
