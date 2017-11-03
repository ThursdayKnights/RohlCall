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

        /*
         * Owner: Thursday Knights,
         * Authors: Christopher Rupert, Peter Adam
         * Description: This DLL will be used for rolling stat dice and keeping track
         * of other random integer uses.
         */

        //Stat rolling method, not very efficient yet.
        public string statRoller()
        {
            int[] stats = new int[4];
            int outPut = 0;
            //Roll a d6 4 times
            for (int x = 0; x < 4; x++)
            {
                //we have to increase the ceiling to 7 because 1, 6 only rolls as high as 5.
                stats[x] = rnd.Next(1, 7);
            }

            //Sort out integers
            Array.Sort(stats);

            //add all results together
            foreach(int x in stats)
            {
                    outPut += x;
            }

            //Drop the lowest value by just minusing it from the total value.
            outPut -= stats[0];

            //For testing phases only.
            return "( " + stats[0] + " + " + stats[1] + " + " + stats[2] + " + " + stats[3] + " )  = " + outPut + " with lowest dropped";
        }

        //Dice roller, created by Peter;
        public string DiceRoll(int diceAmt, int faces)
        {
            //Method for rolling dice as 1D6 or 20D400;
            //Dice faces can be unlimited; and the amount of dice can be unlimited;

            //Increment the amount of faces by one for issue with random.Next
            faces++;

            //Set an array for the dice rolls
            int[] rolls = new int[diceAmt];
            
            //empty string for each time this is called.
            string outPut = "";
            int j = 0;

            //for loop dice rolling
            for(int tot = 0; tot < diceAmt; tot++)
            {
                rolls[tot] = rnd.Next(1, faces);
            }

            //While loop for pretty formatting.  Because pretty formatting is pretty.
            while (j < diceAmt)
            {
                if (j == 0)
                {
                    outPut += "( " + rolls[j] + " + ";
                } else if (j == (diceAmt -1))
                {
                    outPut += rolls[j] + " )";
                } else
                {
                    outPut += rolls[j] + " + ";
                }
                j++;
            }
            
            return outPut;
        }
    }
}
