using System;
using System.Collections.Generic;
using BL;
using Models;

namespace StoreUI {
    public class SearchCustomerMenu : IMenu {
        public static Customer newCustomer = new Customer();
        private ICustomerBL customerBL;
        public SearchCustomerMenu(ICustomerBL customerBL){
            this.customerBL = customerBL;
        }

        public void Menu(){
            Console.WriteLine("----------Customer Search Menu---------");
            Console.WriteLine("How would you like to search?");
            Console.WriteLine("    [2] Search by Name");
            Console.WriteLine("    [1] Search by Customer id");
            Console.WriteLine("    [0] Go Back");
        }

        public MenuType Choice(){

            List<Customer> customers = new List<Customer>();

            string inputValue = Console.ReadLine();

            switch(inputValue) {
                
                case '0':
                    return MenuType.CustomerMenu;
                case '1':
                    List<Models.Customer> cust = new List<Customer>();
                    Console.Write("Enter the id number of the customer you seek: ");
                    int customerId = int.Parse(Console.ReadLine());
                    var result = (from customer in customers
                                  where customer.Id == customerId
                                  select customer);
                    foreach(var c in result){
                        cust.Add(c);
                    }
                    if(cust.Count == 0){
                        Console.WriteLine($"There is no customer with the id {customerId}");
                        Console.WriteLine("Press any Key to continue");
                        Console.ReadKey();
                        return MenuType.SearchCustopmerMenu;
                    }
                    return cust;
                case '2':
                    List<Customers> cust = new List<Customers>();
                    Console.Write("Enter the name of the customer you wish to search:");
                    newCustomer.SetName(Console.ReadLine());
                    if(cust.Contains(newCustomer)){
                        return MenuType.CustomerOptionMenu;
                    }
                    Console.WriteLine("Sorry no customer with that name exists");
                    Console.Write("Press any keyt to continue");
                    Console.ReadKey();
                    return MenuType.SearchCustomerMenu;
                default:
                    return MenuType.SearchCustomerMenu;
            }   
        }
    }
}