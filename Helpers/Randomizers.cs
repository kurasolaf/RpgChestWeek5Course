using System;
using System.Collections.Generic;
using System.Text;

namespace RpgChest
{
    public class Randomizers
    {
        
        
        public int Random5()
        {
            int random5;

            Random rnd5 = new Random();
            random5 = rnd5.Next(1, 6);

            return random5;
        }


        public int Random2()
        {
            int random2;
            Random rnd2 = new Random();
            random2 = rnd2.Next(1, 3);

            return random2;


        }

        public int RandomLvl()
        {
            int randomLvl;
            Random rndLvl = new Random();
            randomLvl = rndLvl.Next(1, 40);

            return randomLvl;

        }


    }
}
