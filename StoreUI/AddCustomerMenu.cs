using System;
using BL;
using DL;
using Models;
namespace StoreUI{
    public class AddCustomerMenu : IMenu {
        public void Menu(){}

        public MenuType Choice(){
            string inputValue = Console.ReadLine();

            switch(inputValue){
                default:
                    return MenuType.AddCustomerMenu;
            }
        }
    }
}