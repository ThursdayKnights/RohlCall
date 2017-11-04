using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohlCall
{
    class TKRCCharacterSheet
    {
        private int ModMath(int stats)
        {
            //Mod math designed for stat modifiers
            //Author: Gerry
            int mod;
            mod = (stats - 10) / 2;
            return mod;
        }
    }
   
}
