using System;
using System.Collections.Generic;
using System.Text;

namespace p26_euler
{
    public class RecurringDigitUnitFractionFinder
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

        public RecurringDigitUnitFractionFinder(int denom)
        {
            ufdr = new UnitFractionDecimalRepresentation(denom);
            Denominator = denom;
        }


        public int GetRecuringCycleCount()
        {
            return 1;
        }


    }
}
