using System;
using System.Collections.Generic;
using DL;
using Models;

namespace BL{
    public class CustomerBL : ICustomerBL{

        private ICustomerRepository custrepo;

        public CustomerBL(ICustomerRepository custrepo){
            this.custrepo = custrepo;
        }

        public Customer AddCustomer(Customer cust){
             custrepo.AddCustomer(cust);
             return cust;
        }

        public List<Customer> GetAllCustomers(){
            return custrepo.GetAllCustomers();
        }

        public Customer GetCustomer(int id){
            return custrepo.GetCustomer(id);
        }

        public Customer GetCustomerByName(string name){
            return custrepo.GetCustomer(name);
        }

    }
}
