using Models;
namespace DL{
    public interface IOrder {
        OrderRepository PlaceOrder(int customerId, int storeId);
    }
}