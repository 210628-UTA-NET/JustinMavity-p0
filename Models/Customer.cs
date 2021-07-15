using System;
using System.Collections.Generic;

namespace Models{
    public class Customer{
        public int Id { get; set; }

        private string name;

        private string address;

        private string email;

        private string phoneNumber;

        private List<Order> orders;

        public Customer(){
        }

        public Customer(string name, string address, string email, string phoneNumber){
            this.name = name;
            this.address = address;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public string GetName(){
            return name;
        }

        public void SetName(string name){
            this.name = name;
        }

        public string GetAddress(){
            return address;
        }

        public void SetAddress(string address){
            this.address = address;
        }

        public string GetEmail(){
            return email;
        }

        public void SetEmail(string email){
            this.email = email;
        }

        public string GetPhoneNumber(){
            return phoneNumber;
        }

        public void SetPhoneNumber(string phoneNumber){
            this.phoneNumber = phoneNumber;
        }

        public List<Order> GetOrders(){
            return orders;
        }

        public void SetOrders(List<Order> orders){
            this.orders = orders;
        }
    }
}
