using System;
using BL;
using DL;
using Models;

namespace StoreUI{

    class Program {

        static void Main(string[] args){

            IMenu theMenu = new MainMenu();
            bool repeat = true;
            MenuType currentMenu = MenuType.MainMenu;
            IFactory menuFactory = new MenuFactory();

            while (repeat){

                Console.Clear();
                Console.WriteLine(Models.Store.GetInventory());
                theMenu.Menu();
                currentMenu = theMenu.Choice();

                switch(currentMenu){

                    case MenuType.MainMenu:
                        theMenu = menuFactory.GetMenu(MenuType.MainMenu);
                        break;
                    case MenuType.CustomerMenu:
                        theMenu = menuFactory.GetMenu(MenuType.CustomerMenu);
                        break;
                    case MenuType.AddCustomerMenu:
                        theMenu = menuFactory.GetMenu(MenuType.AddCustomerMenu);
                        break;
                    case MenuType.ShowCustomerMenu:
                        theMenu = menuFactory.GetMenu(MenuType.ShowCustomerMenu);
                        break;
                    case MenuType.StoreMenu:
                        theMenu = menuFactory.GetMenu(MenuType.StoreMenu);
                        break;
                    case MenuType.Exit:
                        theMenu = menuFactory.GetMenu(MenuType.Exit);
                        break;
                    default:
                        Console.WriteLine("Can not process what you want please try again");
                        break;
                }
            }

        }
    }
}
