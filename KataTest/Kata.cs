using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTest
{
    internal class Kata
    {
        //        In descending order: [10, 2, 1]

        //        Sum: (10 - 2) + (2 - 1) = 8 + 1 = 9

        //If the array is empty or the array has only one element the result should be 0 (Nothing in Haskell ).
        public static int SumOfDifferences(int[] arr)
        {

            Array.Sort(arr);
            Array.Reverse(arr);
            int sum = 0;
            if (arr == null  || arr.Length < 2) return sum;
            else
                for (int i = 1; i < arr.Length; i++)
                {
                    sum += arr[i - 1] - arr[i];
                }
            return sum;
        }
    }
}
