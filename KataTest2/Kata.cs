using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTest2
{
    internal class Kata
    {
        public static int CountBits(int n)
        {
            string binary = Convert.ToString(n, 2);
            int sum = 0;
            foreach (char bit in binary)
            {
                if (bit == '1') sum++;
            }
            return sum;
        }


    }
}
