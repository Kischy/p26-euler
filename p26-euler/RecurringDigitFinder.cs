using System;
using System.Collections.Generic;
using System.Text;

namespace p26_euler
{
    public static class RecurringDigitFinder
    {

        private static bool IndexValid(int index,List<int> numbers, List<int> possRecuringNumbers)
        {
            int maxIndex = possRecuringNumbers.Count -1 + index;

            return maxIndex < numbers.Count;
        }

        private static bool ListsEqual(List<int> lhs, List<int> rhs)
        {
            var lhsSet = new HashSet<int>(lhs);
            return lhsSet.SetEquals(rhs);
        }

        private static bool IsRecuringCycle(List<int> numbers, List<int> possRecuringNumbers)
        {
            for(int numsIndex = 0; numsIndex < numbers.Count; numsIndex+= possRecuringNumbers.Count)
            {

                if(IndexValid(numsIndex,numbers,possRecuringNumbers) == false)
                {
                    return false;
                }

                List<int> numbersToCheck = numbers.GetRange(numsIndex, possRecuringNumbers.Count);

                if (ListsEqual(numbersToCheck,possRecuringNumbers) == false)
                {
                    return false;
                }
            }

            return true;
        }


        public static int GetRecuringCycleCount(List<int> numbers)
        {
            if(numbers.Count == 0)
            {
                return 0;
            }


            for (int index = 0; index < numbers.Count ; ++index)
            {
                for (int length = 1; length <= numbers.Count / 2; ++length)
                {
                    if(index + length - 1 >= numbers.Count)
                    {
                        break;
                    }

                    List<int> possRecc = numbers.GetRange(index, length);

                    if (IsRecuringCycle(numbers, possRecc))
                    {
                        return length;
                    }
                }
            }

            return GetRecuringCycleCount(numbers.GetRange(1,numbers.Count-1));
        }
    }
}
