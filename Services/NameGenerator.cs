using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RpgChest.ItemChoose;

namespace RpgChest
{
    class NameGenerator
    {
        public string WeaponNameGenerator(WeaponsItemChoose type)
        {
            WeaponsItemChoose itType = type;
            string name;

            var adjective = RandomWeaponAdjectiveEnum();
            var noun = RandomWeaponNounEnum();

            name = $"{itType} of {adjective} {noun}";

            return name;

        }

        private WeaponAdjectiveEnum RandomWeaponAdjectiveEnum()
        {
            Randomizers rand5 = new Randomizers();

            int rand = rand5.Random5();

            switch (rand)
            {
                case 1:
                    return WeaponAdjectiveEnum.Holy;
                case 2:
                    return WeaponAdjectiveEnum.Cursed;
                case 3:
                    return WeaponAdjectiveEnum.Evil;
                case 4:
                    return WeaponAdjectiveEnum.Fast;
                case 5:
                    return WeaponAdjectiveEnum.Greedy;
                default:
                    throw new Exception("Error in Random Weapon generator for Adjective");


            }

        }



        private WeaponNounEnum RandomWeaponNounEnum()
        {

            Randomizers rand5 = new Randomizers();

            int rand = rand5.Random5();



            switch (rand)
            {
                case 1:
                    return WeaponNounEnum.Steel;
                case 2:
                    return WeaponNounEnum.Bone;
                case 3:
                    return WeaponNounEnum.Hand;
                case 4:
                    return WeaponNounEnum.Soul;
                case 5:
                    return WeaponNounEnum.Wanderer;
                default:
                    throw new Exception("Error in Random Weapon generator for Noun");


            }


        }

     

    }

}