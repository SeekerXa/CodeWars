using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    //    In this kata you get the start number and the end number of a region and should return the count of all numbers except numbers with a 5 in it.The start and the end number are both inclusive!

    //Examples:

    //1,9 -> 1,2,3,4,6,7,8,9 -> Result 8
    //4,17 -> 4,6,7,8,9,10,11,12,13,14,16,17 -> Result 12
    //The result may contain fives. ;-)
    //The start number will always be smaller than the end number. Both numbers can be also negative!
    internal class Kata
    {

        public static int DontGiveMeFive(int start, int end)
        {
            var count = 0;
            for (int i = start; i <= end; i++)
            {
                var hasfive = false;
                var tempString = i.ToString();
                
                foreach (char c in tempString)
                {
                    if(c == '5') { hasfive = true; break; }
                }
                if(!hasfive) count++;
            }
            return count;


           // return Enumerable.Range(start, end - start + 1).Count(x => !x.ToString().Contains("5"));

           // return Enumerable.Range(start,end-start+1).Where(x => !x.ToString().Contains("5")).Count();



        }

    }


}
