using System;
using System.Threading;
namespace StoreUI{
    public class StoreMenu : IMenu {

        public void Menu(){
            Console.Clear();
            Console.WriteLine("----------------Store Menu---------------");
            Console.WriteLine("");
            Console.WriteLine("Options: ");
            Console.WriteLine("        [2] Get a List of all stores int the database");
            Console.WriteLine("        [1] Search For a Specific Store");
            Console.WriteLine("        [0] Exit");
        }

        public MenuType Choice(){

            string userInput = Console.ReadLine();

            switch(userInput){
                case "0":
                    return MenuType.Exit;
                case "1":
                    return MenuType.StoreMenu;
                case "2":
                    return MenuType.StoreMenu;
                default:
                    return MenuType.StoreMenu;
            }
        }
    }
}