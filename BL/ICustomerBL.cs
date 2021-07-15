using System;
using System.Collections.Generic;
using Models;

namespace BL{
    /// <summary>
    /// Handles all the business logic for the Customer model
    /// </summary>
    public interface ICustomerBL{
        /// <summary>
        /// Gets all the Customers stored in the database
        /// </summary>
        /// <returns>Reutrns a list of Customers from the database</returns>
        IEnumerable<Customer> GetAllCustomers();

        /// <summary>
        /// This will add a customer to the database
        /// </summary>
        /// <param name="customer">This is the customer object to be added to the database</param>
        /// <returns>Returns the customer object that was added to the database</returns>
        Customer AddCustomer(Customer customer);

        /// <summary>
        /// This will return a customer object from the database
        /// </summary>
        /// <param name="id">This is the customer object's id that will be used to search the databae for a matching value</param>
        /// <returns>Returns the customer object from the database that matches the param</returns>
        Customer GetCustomer(int id);

        /// <summary>
        /// This will return a customer object from the database
        /// </summary>
        /// <param name="name">This is the customer objects's name that will be used to search the database for a matcjing value</param>
        /// <returns>Returns the customer object from the database that matches the parm</returns>
        Customer GetCustomerByName(string name);

    }
}