﻿using System;
using System.Collections.Generic;
using System.Text;
using RpgChest.ItemChoose;

namespace RpgChest
{
    //////////////////////////To DO//////////////////////
    // Fix Showing Item properties (not null)
    /////////////////////////To DO///////////////////////


    public class ArmorItem : Item

    {
        public GearItemChoose Type { get; set; }
        public string ArmorName { get; set; }
    

        public override string ToString()
        {

            return $"\r\n It's {ArmorName}\r\n {Type}\r\n LVL: {ItemLvl}\r\n KP: {Kp} \r\n HP: {Hp} \r\n ID:{Id}";

        }


    }
}
