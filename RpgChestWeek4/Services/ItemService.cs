using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using RpgChest.Helpers;
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

    public void AskingForMultiplier()
    {
        Console.WriteLine("\r\n Enter how many items should be rolled");
        InputIntValidation InputValid = new InputIntValidation();

        string input = Console.ReadLine();

        bool valid = InputValid.InputNumber(input);

        if (valid == true)
        {
            int rollTimeNumber;
            rollTimeNumber = Int32.Parse(input);

            if (rollTimeNumber > 0)
            {
                MultipleMakingFullItem(rollTimeNumber);
            }
            else if (rollTimeNumber == 0)
            {

                Console.WriteLine("Error, you CANT multiply by 0 (cw)");

            }
            else
            {
                Console.WriteLine("Error, you CANT multiply by negative number (cw)");
                valid = false;
            }
        }
        else if (valid == false)
        {
            
            Console.WriteLine("Error, this is NOT a number (cw)");
            
            throw new Exception("Error, this is NOT a number");

        }
        

    }

        //Overloaded AskingForMultiplier() For Testing
        public void AskingForMultiplier(string dataIn)
    {
       
        InputIntValidation InputValid = new InputIntValidation();

        
        string input;
        input = dataIn;

        bool valid = InputValid.InputNumber(input);

        if (valid == true)
        {
            int rollTimeNumber;
            rollTimeNumber = Int32.Parse(input);
            MultipleMakingFullItem(rollTimeNumber);
        }
        else if (valid == false)
        {
            Console.WriteLine("Error, this is NOT a number (cw)");
            throw new Exception("Error, this is NOT a number");

        }


    }






        public void MultipleMakingFullItem(int rollTimeNumber)
    {
        int maxRoll = rollTimeNumber;

        for (int i = 0; i < maxRoll; i++)
        {
            MakingFullItem();
        }
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











        /// 
        /// Refactor below with LINQ
        /// 
        public void ItemDetailView(int detailId)
    {

        foreach (var item in Items)
        {
            if (item.Id == detailId)
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