using System;

namespace Models{
    public class Customer{
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public Customer(){
        }

        public Customer(string naem, string address, string email, string phoneNumber){
            Name = Name;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
