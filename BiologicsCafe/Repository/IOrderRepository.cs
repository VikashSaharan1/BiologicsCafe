

using BiologicsCafe.Models;

namespace BiologicsCafe.Repository
{
    public interface IOrderRepository
    {
        IList<OrderItem> GetOrders();
        decimal GetSubtotalOrderItem();
        void AddOrderItem(OrderItem orderItem);
        void UpdateQuantity(MenuItem menuItem, int Quantity);
    }
}
