using System.Collections.Generic;
using Models;

namespace DL{
    /// <summary>
    /// Responsible for accessing the database
    /// </summary>
    public interface ICustomerRepository{
         /// <summary>
        /// Gets a list o Customers stored in the database
        /// </summary>
        /// <returns>Returns a list of Customers</returns>
        List<Customer> GetAllCustomers();

        /// <summary>
        /// This will get a specific Customer
        /// </summary>
        /// <param name="cust">This Customer object will be used to check the database from any customer object that match</param>
        /// <returns>Will return the Customer object from the database</returns>
        Customer GetCustomer(int id);

        /// <summary>
        /// It will add a customer to the database
        /// </summary>
        /// <param name="cust">This is customer object that will be added to the database</param>
        /// <returns>Will return the customer object we just added</returns>
        Customer AddCustomer(Customer cust);
    }
}