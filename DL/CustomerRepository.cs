using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;
using Entity = DL.Entities;
using System.Linq;

namespace DL{
   public class CustomerRepository : ICustomerRepository{
        private Entities.StoreManagerDbContext context;

        public CustomerRepository(Entity.StoreManagerDbContext context){
            this.context = context;
        }

        public void AddCustomer(Customer cust){
            context.Add<Customer>(cust);
            context.SaveChanges();
        }

        public IEnumerable<Models.Customer> GetAllCustomers(){
            return (IEnumerable<Customer>)context.Customers.ToList();
        }

        public Models.Customer GetCustomer(string name) {
            Models.Customer cust = new Models.Customer();
            var listOfCustomers = GetAllCustomers();
            foreach(Models.Customer c in listOfCustomers){
                if(c.GetName() == name){
                    cust = c;
                } else{
                    throw new Exception($"Sorry but there is no customer with id {name}");
                }
            }
            return cust;
        }

        public Models.Customer GetCustomer(int id) {
            Models.Customer cust = new Models.Customer();
            var listOfCustomers = GetAllCustomers();
            foreach(Models.Customer c in listOfCustomers){
                if(c.Id == id){
                    cust = c;
                } else{
                    throw new Exception($"Sorry but there is no customer with id {id}");
                }
            }
            return cust;
        }
    }
}
