using System;
using System.Threading;
namespace StoreUI{
    public class ShowCustomerMenu : IMenu {
        public void Menu(){

        }

        public MenuType Choice(){

            string userInput = Console.ReadLine();

            switch(userInput){
                default: 
                    return MenuType.ShowCustomerMenu;
            }
        }
    }
}