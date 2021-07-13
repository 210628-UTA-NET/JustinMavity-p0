using System;
using System.Collections.Generic;
using Model = Models;
using Entity = DL.Entities;
using System.Linq;

namespace DL{
    public class OrderRepository : IOrderRepository {
        private ItemRepository itemrepo;
        private Entities.StoreManagerDbContext context;

        public OrderRepository(Entity.StoreManagerDbContext context){
            this.context = context;
        }


        public IEnumerable<Model.Order> GetAllOrders(){
            return context.Orders.Select(
                ord => 
                    new Model.Order(){
                        StoreId = ord.StoreId
                    }
            ).ToList();
        }

        public Model.Order GetOrder(int id){
            Model.Order order = new Model.Order();
             var listOfOrders = GetAllOrders();
             foreach(Model.Order o in listOfOrders){
                 if(o.Id == id){
                     order = o;
                 }
                 else {
                     throw new System.Exception($"Sorry but there is no order with the id {id}");
                 }
             }
             return order;
        }

        public List<Model.Item> GetItems(int id){
            Model.Order o = GetOrder(id);
            var listOfItems = new List<Model.Item>();
            foreach(var ele in o.Items){
                listOfItems.Append(ele);
            }
            return listOfItems;
        }

        public decimal SetPrice(int orderId){
            Model.Order  order = GetOrder(orderId);
            double price = 0.00;
            var listOfItems = new List<Model.Item>();
            foreach(var ele in order.Items){
                price +=  ele.Price;
            }
            return Convert.ToDecimal(price);
        }
    }
}