using System;

namespace p26_euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculation started");


            RecurringDigitUnitFractionFinder rdf = new RecurringDigitUnitFractionFinder(2);

            for(int i = 2; i < 1000; ++i)
            {

            }


            int answer_p26 = 0;

            Console.WriteLine("The answer to problem 26 of project Euler is " + answer_p26 + ".");
        }
    }
}
