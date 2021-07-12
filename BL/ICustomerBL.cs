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

         /// <summary>
         /// This will allow you to create a new Customer object and store that object inside the database
         /// </summary>
         /// <param name="customer"></param>
         /// <returns>Returns the new created Customer object</returns>

         Customer AddCustomer(Customer customer);
    }
}