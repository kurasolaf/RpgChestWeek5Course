﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RpgChest
{
    
    public class MenuActionService
    {
        
        
        private List<MenuAction> menuActions;

        public MenuActionService()
        {
            menuActions = new List<MenuAction>();
        }
   
        public void AddNewAction(int id, string name, string menuName)
        {
            MenuAction menuAction = new MenuAction(){ Id = id, Name = name, MenuName = menuName};
            menuActions.Add(menuAction);
        }

        
        public List<MenuAction> GetMenuActionByMenuName(string menuName)
        { 
        
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in menuActions )
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }

            return result;

        }








        
    }
}
