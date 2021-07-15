using System;
using BL;
using DL;
using Models;
namespace StoreUI{
    public class AddCustomerMenu : IMenu {

        private static Customer newCustomer = new Customer();
        private ICustomerBL customerBL;

        public AddCustomerMenu(ICustomerBL customerBL){
            this.customerBL = customerBL;
        }
        public void Menu(){
            Console.Clear();
            Console.WriteLine("-----------Add Customer-----------");
            Console.WriteLine();
            Console.WriteLine("[5] Name - " + newCustomer.GetName());
            Console.WriteLine("[4] Address - " + newCustomer.GetAddress());
            Console.WriteLine("[3] PhoneNumber - " + newCustomer.GetPhoneNumber());
            Console.WriteLine("[2] Email - " + newCustomer.GetEmail());
            Console.WriteLine("[1] Add Customer");
            Console.WriteLine("[0] Go Back");
        }

        public MenuType Choice(){
            string inputValue = Console.ReadLine();

            switch(inputValue){
                case "0":
                    return MenuType.CustomerMenu;
                case "1":
                    customerBL.AddCustomer(newCustomer);
                    return MenuType.AddCustomerMenu;
                case "2":
                    newCustomer.SetEmail(Console.ReadLine());
                    return MenuType.AddCustomerMenu;
                case "3":
                    newCustomer.SetPhoneNumber(Console.ReadLine());
                    return MenuType.AddCustomerMenu;
                case "4":
                    newCustomer.SetAddress(Console.ReadLine());
                    return MenuType.AddCustomerMenu;
                case "5":
                    newCustomer.SetName(Console.ReadLine());
                    return MenuType.AddCustomerMenu;
                default:
                    return MenuType.AddCustomerMenu;
            }
        }
    }
}