using BiologicsCafe.Models;
using BiologicsCafe.Repository;

namespace BiologicsCafe.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
           _orderRepository = orderRepository;
        }

        public void AddOrder(MenuItem item, int quantity)
        {
            var orderItem = _orderRepository.GetOrders()?.FirstOrDefault(o => o.Item.Name == item.Name);
            if (orderItem != null)
                _orderRepository.UpdateQuantity(item, quantity);
            else
                _orderRepository.AddOrderItem(new OrderItem { Item = item, Quantity = quantity });
        }

        public IList<OrderItem> GetOrderItems() => _orderRepository.GetOrders();

        public decimal GetSubtotal() => _orderRepository.GetSubtotalOrderItem();
    }
}
