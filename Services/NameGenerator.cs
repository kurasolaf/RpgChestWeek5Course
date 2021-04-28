using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RpgChest.ItemChoose;
using RpgChest.Models.Enums;

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

        public string ArmorNameGenerator(GearItemChoose type)
        {
            GearItemChoose itType = type;
            string name;
            var adjective = RandomArmorAdjectiveEnum();
            var noun = RandomArmorNounEnum();
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

        private ArmorAdjectiveEnum RandomArmorAdjectiveEnum()
        {
            Randomizers rand5 = new Randomizers();
            int rand = rand5.Random5();
            switch (rand)
            {

                case 1:
                    return ArmorAdjectiveEnum.Holy;
                case 2:
                    return ArmorAdjectiveEnum.Sacred;
                case 3:
                    return ArmorAdjectiveEnum.Strong;
                case 4:
                    return ArmorAdjectiveEnum.Tough;
                case 5:
                    return ArmorAdjectiveEnum.Immortal;
                default:
                    throw new Exception("Error in Random Armor generator for Adjective");


            }


        }

        private ArmorNounEnum RandomArmorNounEnum()
        {
            Randomizers rand5 = new Randomizers();
            int rand = rand5.Random5();

            switch (rand)
            {
                case 1:
                    return ArmorNounEnum.Steel;
                case 2:
                    return ArmorNounEnum.Bone;
                case 3:
                    return ArmorNounEnum.Turtle;
                case 4:
                    return ArmorNounEnum.Angel;
                case 5:
                    return ArmorNounEnum.Templar;
                default:
                    throw new Exception("Error in Random Armor generator for Noun");

            }

        }

    }

}