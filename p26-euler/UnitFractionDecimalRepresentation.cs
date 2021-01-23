using System;
using System.Collections.Generic;
using System.Text;

namespace p26_euler
{
    public class UnitFractionDecimalRepresentation
    {

        private int denominator;


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
            }

             
        }

        public UnitFractionDecimalRepresentation(int denom)
        {
            Denominator = denom;
        }

        public int GetNextDigit()
        {
            return 5;
        }


    }
}
