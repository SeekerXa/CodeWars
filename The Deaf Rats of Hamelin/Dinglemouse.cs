using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Deaf_Rats_of_Hamelin
{
    internal class Dinglemouse
    {
        //        The Pied Piper has been enlisted to play his magical tune and coax all the rats out of town.

        //But some of the rats are deaf and are going the wrong way!


        //Kata Task
        //How many deaf rats are there?


        //Legend
        //P = The Pied Piper
        //O~ = Rat going left
        //~O = Rat going right
        //Example
        //ex1 ~O~O~O~O P has 0 deaf rats

        //ex2 P O ~O~ ~O O ~has 1 deaf rat
        //    01234567890
        //ex3 ~O~O~O~OP~O~OO~has 2 deaf rats

        public static int FindPair(string town)
        {
            if (town.Length > 1)
            {
                var case1 = "P~";
                var case2 = "~P";
                for (int i = 0; i < town.Length; i++)
                {
                    if (((town[i] + town[i + 1]) == case1) || (town[i] + town[i + -1] == case2))  )
                }


                return 0;
            }
        }

        public static int CountDeafRats(string town)
        {
            int startPos = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < town.Length; i++)
            {
                if (town[i] == '0' || town[i] == '~' || town[i] == 'P')
                {
                    sb.Append(town[i]);
                    if (town[i] != 'P') startPos++;
                }

            }

            town = sb.ToString();




            return 0;
            // Your code here

        }
    }
}
}
}