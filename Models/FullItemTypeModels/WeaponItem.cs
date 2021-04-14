using System;
using System.Collections.Generic;
using System.Text;
using RpgChest.ItemChoose;

namespace RpgChest
{
    //////////////////////////To DO//////////////////////
    // Fix Showing Item properties (not null)
    /////////////////////////To DO///////////////////////
    public class WeaponItem : Item
    {
        public WeaponsItemChoose Type { get; set; }

      



        public override string ToString()
        {

            return $"\r\n It's {Type}\r\n LVL: {ItemLvl}\r\n DMG: {Dmg} \r\n Crit: {CritChance} \r\n ID:{Id}";

        }
    }
}
