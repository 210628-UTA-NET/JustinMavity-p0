using System.Collections.Generic;
using Models;
namespace DL{
    public interface IOrderRepository{

        decimal SetPrice(int orderId);

        IEnumerable<Order> GetAllOrders();

        Order GetOrder(int id);

        List<Item> GetItems(int id);
    }
}