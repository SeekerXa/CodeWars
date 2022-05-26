using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Dinglemouse
    {
        //        Story
        //POTUS thinks he is all alone in the White House on Christmas Eve.

        //But is he?

        //The White House has a wall-penetrating radar security system that sees everything.

        //Kata Task
        //Process the radar image.


        //Return true if POTUS really is home alone.


        //Legend
        //# walls
        //X POTUS
        //o elves
        //Notes
        //The house corners are square only
        //The radar can also see into nearby buildings
        //Examples
        //ex1

        //   o               o         #######
        // ###############             #     #
        // #             #        o    #     #
        // #  X          ###############     #
        // #                                 #
        // ###################################
        //All alone --> true


        //ex2
        //#################
        //#     o         #   o
        //#          ######        o
        //####       #                
        //   #       ###################
        //   #                         #
        //   # X                       #
        //   ###########################
        //All alone --> false


        public static bool AllAlone(char[][] house)
        {
             for (int x = 0; x < house.GetLength(0); x++)
            {
                for (int y = 0; y < house[x].Length; y++)
                {
                    if (house[x][y] == 'X')
                    {
                        return !Scan(house, x, y);
                    }
                }
            } 
             return false;
        }

        public static bool Scan(char[][] house, int x, int y)
        {
            var cur = house[x][y];
            house[x][y] = '#';
            if (cur == '#') return false;
            if (cur == 'o') return true;

            return Scan(house, x + 1, y) || Scan(house, x - 1, y) || Scan(house, x, y - 1) || Scan(house, x, y + 1);
        }


    }
}
