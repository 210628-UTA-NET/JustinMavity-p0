using System;
using System.Threading;
namespace StoreUI{
    public class CustomerMenu : IMenu {
        public void Menu(){
            Console.WriteLine("-------------Welcome to the Customer Menu--------------");
            Console.WriteLine("  What would you like to do?");
            Console.WriteLine("     [2] Add a Customer");
            Console.WriteLine("     [1] Get list of Customers");
            Console.WriteLine("     [0] Go Back");
        }

        public MenuType Choice(){

            string userInput = Console.ReadLine();

            switch(userInput){
                case "0":
                    return MenuType.MainMenu;
                case "1":
                    return MenuType.ShowCustomerMenu;
                case "2":
                    return MenuType.AddCustomerMenu;
                default:
                    Console.WriteLine("Input was not valid");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}