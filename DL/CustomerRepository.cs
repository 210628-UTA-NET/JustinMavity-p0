// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Text.Json;
// using Entity = DL.Entities;
// using System.Linq;

// namespace DL{
//    public class CustomerRepository : ICustomerRepository{
//         private Entities.StoreManagerDbContext context;

//         public CustomerRepository(Entity.StoreManagerDbContext context){
//             this.context = context;
//         }

//         public Models.Customer AddCustomer(Models.Customer cust){
//             context.Customers.Add(new Entity.Customers{
//                 CustId = cust.Id,
//                 CustName = cust.Name,
//                 CustAddress = cust.Address,
//                 Email = cust.Email,
//                 PhoneNumber = cust.PhoneNumber
//             });

//             context.SaveChanges();
//             return cust;
//         }

//         public List<Models.Customer> GetAllCustomers(){
//             return context.Customers.Select(
//                 cust =>
//                     new Models.Customer(){
//                         Id = cust.CustId,
//                         Name = cust.CustName,
//                         Address = cust.CustAddress,
//                         Email = cust.Email,
//                         PhoneNumber = cust.PhoneNumber
//                     }
//             ).ToList();
//         }

//         public Models.Customer GetCustomer(int id) {
//             Models.Customer cust = new Models.Customer();
//             var listOfCustomers = GetAllCustomers();
//             foreach(Models.Customer c in listOfCustomers){
//                 if(c.Id == id){
//                     cust = c;
//                 } else{
//                     throw new Exception($"Sorry but there is no customer with id {id}");
//                 }
//             }
//             return cust;
//         }
//     }
// }
