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

        public static int FindingDeafRats(string town, int pPos)
        {

            var count = 0;
            if (town.Length > 2)
            {
                if (pPos == 0)
                {
                    count = town[pPos + 1] == '~' ? count + 1 : count = 0;
                    town = town.Remove(pPos + 1, 2);
                }
                else
                {
                    count = town[pPos - 1] == '~' ? count + 1 : count = 0;
                    town = town.Remove(pPos - 2, 2);

                }
                return count + FindingDeafRats(town, FindP(town));
            }
            return 0;
        }
        public static int FindP(string town)
        {
            for (int i = 0; i < town.Length; i++)
            {
                if (town[i] == 'P') return i;

            }
            return 0;
        }
        public static int CountDeafRats(string town)
        {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < town.Length; i++)
            {
                if (town[i] == 'O' || town[i] == '~' || town[i] == 'P')
                {
                    sb.Append(town[i]);
                }
            }
            town = sb.ToString();

            return FindingDeafRats(town, FindP(town));

        }



        // best 



        //public static int CountDeafRats(string town)
        //{
        //    var rats = town.Replace(" ", "").Split('P');
        //    var leftCount = rats[0].Where((x, i) => i % 2 == 1).Count(x => x == '~');
        //    var rightCount = rats[1].Where((x, i) => i % 2 == 0).Count(x => x == '~');
        //    return leftCount + rightCount;
        //}


        //public static int CountDeafRats(string town)
        //{
        //    return town
        //            .Replace(" ", "")
        //            .Where((x, i) => i % 2 == 0)
        //            .Count(x => x == 'O');
        //}



    }




}
