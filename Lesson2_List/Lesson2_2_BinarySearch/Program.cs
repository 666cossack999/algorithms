using System;
using System.Collections.Generic;

namespace Lesson2_2_BinarySearch
{
    class Program
    {
        public static int BinarySearch(List<int> inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Count - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }


        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next(0, 20)) ;
            }

            list.Sort();

            BinarySearch(list, 5);

        }
    }
}
