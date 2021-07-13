using System;
using System.Collections.Generic;
using Models;

namespace StoreBL{
    /// <summary>
    /// Handles all the business logic for the Customer model
    /// </summary>
    public interface ICustomerBL{
        /// <summary>
        /// Gets all the Customers stored in the database
        /// </summary>
        /// <returns>Reutrns a list of Customers from the database</returns>
        List<Customer> GetAllCustomers();

        Customer AddCustomer(Customer customer);

        Customer GetCustomer(int id);
        Customer GetCustomerByName(string name);

    }
}