using System;
using System.Collections.Generic;
using DL;
using Models;

namespace StoreBL{
    public class CustomerBL : ICustomerBL{

        private ICustomerRepository custrepo;

        public CustomerBL(ICustomerRepository custrepo){
            this.custrepo = custrepo;
        }

        public Customer AddCustomer(Customer cust){
            return custrepo.AddCustomer(cust);
        }

        public List<Customer> GetAllCustomers(){
            return custrepo.GetAllCustomers();
        }
    }
}
