using System;
using System.Collections.Generic;
using System.Text;
using RpgChest.ItemChoose;

namespace RpgChest
{
    public class ArmorItemBuilder
    {
        //////////////////////////To DO//////////////////////
        // Fix Showing Item properties (not null)
        // Fix properties
        /////////////////////////To DO///////////////////////
        public Item ArmorRollForStat()
        {
            Randomizers statRandomizer = new Randomizers();
            ArmorItem armor = new ArmorItem();
            NameGenerator name = new NameGenerator();
            GearItemChoose type;

            armor.Hp = statRandomizer.Random5();
            armor.Kp = statRandomizer.Random5();
            armor.ItemLvl = statRandomizer.RandomLvl();
            armor.Type = GearRandomMethod();
            type = armor.Type;
            armor.ArmorName = name.ArmorNameGenerator(type);
            armor.Dmg = 0;
            armor.CritChance = 0;
            

            return armor;
        }


        public GearItemChoose GearRandomMethod()
        {
            Randomizers randomizers = new Randomizers();

            int gear =  randomizers.Random10();

            switch (gear)
            {
                case 1:
                    return GearItemChoose.Armor;
                case 2:
                    return GearItemChoose.Helmet;
                case 3:
                    return GearItemChoose.Legs;
                case 4:
                    return GearItemChoose.Gloves;
                case 5:
                    return GearItemChoose.Boots;
                case 6:
                    return GearItemChoose.Belt;
                case 7:
                    return GearItemChoose.Shield;
                case 8:
                    return GearItemChoose.Ring;
                case 9:
                    return GearItemChoose.Necklace;
                case 10:
                    return GearItemChoose.Earrings;
                default:
                    throw new Exception("error - ArmorItemChoose");
                   
            }
  
        }

        //method for manual rolling item
        public GearItemChoose GearRandomMethod(int numb)
        {
            
            switch (numb)
            {
                case 1:
                    return GearItemChoose.Armor;
                case 2:
                    return GearItemChoose.Helmet;
                case 3:
                    return GearItemChoose.Legs;
                case 4:
                    return GearItemChoose.Gloves;
                case 5:
                    return GearItemChoose.Boots;
                case 6:
                    return GearItemChoose.Belt;
                case 7:
                    return GearItemChoose.Shield;
                case 8:
                    return GearItemChoose.Ring;
                case 9:
                    return GearItemChoose.Necklace;
                case 10:
                    return GearItemChoose.Earrings;
                default:
                    throw new Exception("error - ArmorItemChoose");

            }

        }













    }
}
