using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohlCall
{
    class TKRCDiceRollers
    {
        Random rnd = new Random();
        public string statRoller()
        {
            int[] stats = new int[4];
            for (int x = 0; x < 4; x++)
            {
                stats[x] = rnd.Next(1, 7);
            }
            Array.Sort(stats);
            //hi gerry
            return "( " + stats[0] + " + " + stats[1] + " + " + stats[2] + " + " + stats[3] + " )";
        }
    }
}
