using System;

namespace p26_euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculation started");


            RecurringDigitUnitFractionFinder longest_rdf = new RecurringDigitUnitFractionFinder(2);

            for(int i = 3; i < 1000; ++i)
            {
                RecurringDigitUnitFractionFinder rdf = new RecurringDigitUnitFractionFinder(i);

                if (rdf.GetRecuringCycleCount() > longest_rdf.GetRecuringCycleCount())
                {
                    longest_rdf = rdf;
                }
            }


            int answer_p26 = longest_rdf.Denominator;


            Console.Write("The answer to problem 26 of project Euler is " + answer_p26 + ".");
            Console.WriteLine("The length of the recurring cycle is " + longest_rdf.GetRecuringCycleCount() + ".");
        }
    }
}
