using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task3
{

    //    Write a method, that will get an integer array as parameter and will process every number from this array.

    //Return a new array with processing every number of the input-array like this:

    //If the number has an integer square root, take this, otherwise square the number.

    //Example
    //[4, 3, 9, 7, 2, 1] -> [2,9,3,49,4,1]
    //Notes
    //The input array will always contain only positive numbers, and will never be empty or null.
    // var input = new int[]    { 4, 3, 9, 7,  2, 1 };
    // var expected = new int[] { 2, 9, 3, 49, 4, 1 };

    public class Kata
    {

        public static int[] SquareOrSquareRoot(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % Math.Sqrt(array[i]) == 0)
                {
                    array[i] = (int)Math.Sqrt(array[i]);
                }
                else array[i] = (int)Math.Pow(array[i], 2);
            }
            return array;

            // Better by lambda
            // return array.Select(x => (int)(Math.Sqrt(x) % 1 == 0 ? Math.Sqrt(x) : x * x)).ToArray();
        }

    }
}
