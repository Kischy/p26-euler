using System;
using System.Collections.Generic;
using System.Text;

namespace p26_euler
{
    public class RecurringDigitFinder
    {
        private UnitFractionDecimalRepresentation ufdr;
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

        public RecurringDigitFinder(int denom)
        {
            Denominator = denom;
            ufdr = new UnitFractionDecimalRepresentation(denom);
        }


        public int GetRecuringCycleCount()
        {
            return 1;
        }


    }
}
