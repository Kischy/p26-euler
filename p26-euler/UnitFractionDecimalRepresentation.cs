using System;
using System.Collections.Generic;
using System.Text;

namespace p26_euler
{
    public class UnitFractionDecimalRepresentation
    {

        private int denominator;
        private int numerator = 10;
        private int nextDigit = 0;


        public int Denominator 
        {
            get
            {
                return denominator;
            }

            set
            {
                if(value < 2)
                {
                    throw new ArgumentException("Value must be at least 2 or higher.");
                }

                denominator = value;
                Reset();
            }

             
        }

        private void Reset()
        {
            numerator = 10;
            nextDigit = 0;
        }

        private void AdjustNumerator()
        {
            numerator -= nextDigit * denominator;
            numerator *= 10;
        }

        private bool DecimalRepresentationHasEnded()
        {
            return numerator == 0;
        }

        public UnitFractionDecimalRepresentation(int denom)
        {
            Denominator = denom;
        }

        public int GetNextDigit()
        {
            if(DecimalRepresentationHasEnded())
            {
                return -1;
            }

            nextDigit = numerator / denominator;

            AdjustNumerator();

            return nextDigit;
        }


    }
}
