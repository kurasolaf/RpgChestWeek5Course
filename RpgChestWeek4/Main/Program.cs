﻿using System;
using RpgChest.Helpers;

namespace RpgChest
{
    public class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////TO DO////////////////////////////////////////////////
            //1 - kreator pojedynczego przedmiotu
            //2 - dodac osobno losowanie dla kazdej statystyki 
            //3 - dodatkowe statystyki(wlasciwosci) przedmiotow
            ///////////////////////////////TO DO///////////////////////////////////////////////
           

            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);
            
            Console.WriteLine("Welcome to RPG Chest App\r\n\r\n");

            ItemService mainItemList = new ItemService();
            
            while (true) { 
            Console.WriteLine("What do you want to do\r\n");

                var mainMenu = actionService.GetMenuActionByMenuName("Main");
                for (int i = 0; i <mainMenu.Count; i++)
                {
                Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                }

                 var operation = Console.ReadKey();
                switch (operation.KeyChar)
                {
                case '1':
                    new Exception("Add item manualy - not implemented");
                    return;
                case '2':
                    Console.WriteLine("\r\n");
                    mainItemList.MakingFullItem();
                    break;
                case '3':
                    mainItemList.AskingForMultiplier();
                    break;

                case '4': 
                    Console.WriteLine("\r\n LIST OF ALL ITEMS"); 
                    mainItemList.ItemListView();

                    break;

                case '5':
                    var detailId = mainItemList.ItemDetailSelectionView();
                    mainItemList.ItemDetailView(detailId);
                    break;
                case '6':
                    PdfDownloader pdfDownloader = new PdfDownloader();
                    pdfDownloader.PdfDownloadMethod();
                    break;

                    default:
                    Console.WriteLine("Wrong action. please make correct one");
                    break;
                }

            }
        }

        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Add new item manually - not implemented yet", "Main" );
            actionService.AddNewAction(2, "Roll for one random Item", "Main");
            actionService.AddNewAction(3,"Roll for multiple random Items", "Main");
            actionService.AddNewAction(4, "List of Items", "Main");
            actionService.AddNewAction(5, "Detailed Item", "Main");
            actionService.AddNewAction(6, "PDF download", "Main");

            return actionService;
        }

    }
}

