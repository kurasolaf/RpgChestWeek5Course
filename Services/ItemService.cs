using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Linq;
using System.Threading.Channels;
using RpgChest.ItemChoose;


namespace RpgChest
{
    //////////////////////////To DO//////////////////////
    // Make roll for all kinds of items (full iems, scrolls, gems, etc)
    // 
    /////////////////////////To DO///////////////////////
    public class ItemService
    {

        private int LastId { get; set; } = 1;

        public List<Item> Items { get; set; } = new List<Item>();

        public void MakingFullItem()
        {
            Item fullItem = ItemBuilder();

            fullItem.Id = LastId++; 

            Items.Add(fullItem);
            Console.WriteLine("Item has been generated");

        }

        public Item ItemBuilder()
        {
            Randomizers randomizers = new Randomizers();
            int rand2 = randomizers.Random2();

   
            switch (rand2)
            {
                case 1:
                    ArmorItemBuilder armorItemBuilder = new ArmorItemBuilder();
                    return armorItemBuilder.ArmorRollForStat();

                case 2:
                    WeaponItemBuilder weaponItemBuilder = new WeaponItemBuilder();
                    return weaponItemBuilder.WeaponRollForStat();
                default:
                    throw new InvalidOperationException("Unknown item type");
            }

        }

        public void ItemDetailView(int detailId)
        {

            foreach (var item in Items)
            {
                if (item.Id == detailId )
                {
                    Console.WriteLine(item.ToString());
                    break;
                }
                
            }
            
        }


        public int ItemDetailSelectionView()
        {
            Console.WriteLine("\r\nPlease enter ID, for details to show");
            var itemId = Console.ReadKey();
            int id;
            Int32.TryParse(itemId.KeyChar.ToString(), out id);


            return id;
        }


        public void ItemListView()
        {
            foreach (var item in Items)
            {
                
                Console.WriteLine($"ID:{item.Id} Item LVL:{item.ItemLvl}"); 
            }

        }
    }
}