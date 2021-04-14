using System;
using System.Collections.Generic;
using System.Text;
using RpgChest.ItemChoose;

namespace RpgChest
{
    class ArmorItemBuilder
    {
        //////////////////////////To DO//////////////////////
        // Fix Showing Item properties (not null)
        // Fix properties
        /////////////////////////To DO///////////////////////
        public Item ArmorRollForStat()
        {
            Randomizers statRandomizer = new Randomizers();

            ArmorItem armor = new ArmorItem();

            armor.Hp = statRandomizer.Random5();
            armor.Kp = statRandomizer.Random5();
            armor.ItemLvl = statRandomizer.RandomLvl();
            armor.Type = GearRandomMethod();
            armor.Dmg = 0;
            armor.CritChance = 0;
            

            return armor;
        }


        public GearItemChoose GearRandomMethod()
        {
            Randomizers randomizers = new Randomizers();

            int gear =  randomizers.Random5();

            switch (gear)
            {
                case 1:
                    return GearItemChoose.Armor;
                case 2:
                    return GearItemChoose.Helmet;
                case 3:
                    return GearItemChoose.Legs;
                case 4:
                    return GearItemChoose.Boots;
                case 5:
                    return GearItemChoose.Gloves;
                default:
                    throw new Exception("error - ArmorItemChoose");
                   
            }
  
        }

    }
}
