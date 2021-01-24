using System;
using System.Collections.Generic;
using System.Text;

namespace p26_euler
{
    public class RecurringDigitUnitFractionFinder
    {


        private UnitFractionDecimalRepresentation ufdr;

        private bool RecuringCylcleCountHasBeenCalculated = false;
        private int recuringCycleCount;

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

        private void CalcRecuringCycleNumber()
        {
            while (MightBeRecuringCycleNumber())
            {
                ufdr.GetNextDigit();
                int currRemainder = ufdr.LastRemainder();
                int index = ufdr.Remainders.IndexOf(currRemainder);

                if (IsValidIndex(index) && IndexIsNotTheSameAsCurrent(index))
                {
                    recuringCycleCount = (ufdr.Remainders.Count - 1) - index;
                    return;
                }

                if (MaxCountReached())
                {
                    break;
                }

            }

            recuringCycleCount = 0;
        }


        public int Denominator
        {
            get
            {
                return ufdr.Denominator;
            }

            set
            {
                ufdr.Denominator = value;
                RecuringCylcleCountHasBeenCalculated = false;
            }
        }

        public RecurringDigitUnitFractionFinder(int denom)
        {

            ufdr = new UnitFractionDecimalRepresentation(denom);
            Denominator = denom;
        }





        public int GetRecuringCycleCount()
        {

            if (RecuringCylcleCountHasBeenCalculated)
            {
                return recuringCycleCount;
            }
            else
            {
                CalcRecuringCycleNumber();
                RecuringCylcleCountHasBeenCalculated = true;
                return recuringCycleCount;
            }


        }
    }
}
