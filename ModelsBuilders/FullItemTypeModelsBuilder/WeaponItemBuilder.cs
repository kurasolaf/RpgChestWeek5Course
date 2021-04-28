using System;
using System.Collections.Generic;
using System.Text;
using RpgChest.ItemChoose;

namespace RpgChest
{
    //////////////////////////To DO//////////////////////
    // Fix Showing Item properties (not null)
    // Fix properties
    /////////////////////////To DO///////////////////////
    class WeaponItemBuilder
    {

        public Item WeaponRollForStat()
        {
            Randomizers statRandomizer = new Randomizers();
            WeaponItem weapon = new WeaponItem();
            NameGenerator nameGenerator = new NameGenerator();
            WeaponsItemChoose type;
            
               
               weapon.Dmg = statRandomizer.Random5();
               weapon.CritChance = statRandomizer.Random5();
               weapon.ItemLvl = statRandomizer.RandomLvl();
               weapon.Type = WeaponRandomMethod();
               type = weapon.Type;
               weapon.WeaponName = nameGenerator.WeaponNameGenerator(type);
               weapon.Hp = 0;
               weapon.Kp = 0;
               

               return weapon;

        }


        public WeaponsItemChoose WeaponRandomMethod()
        {

            Randomizers randomizers = new Randomizers();

            int gear = randomizers.Random5();

            switch (gear)
            {
                case 1:
                    return WeaponsItemChoose.LongBow;
                case 2:
                    return WeaponsItemChoose.Bow;
                case 3:
                    return WeaponsItemChoose.ElvenBow;
                case 4:
                    return WeaponsItemChoose.Crossbow;
                case 5:
                    return WeaponsItemChoose.OneHSword;
                case 6:
                    return WeaponsItemChoose.MagicalStaff;
                default:
                    throw new Exception("error  - WeaponItemChoose");

            }

        }

    }
}
