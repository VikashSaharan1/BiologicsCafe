using BiologicsCafe.Models;

namespace BiologicsCafe.Services
{
    public class OrderService
    {
        private readonly List<OrderItem> _orderItems;
        public OrderService()
        {
            _orderItems = new List<OrderItem>();
        }

        public void AddOrder(MenuItem item, int quantity)
        {
            var orderItem = _orderItems.FirstOrDefault(o => o.Item.Name == item.Name);
            if(orderItem != null)
                orderItem.Quantity += quantity;
            else
                _orderItems.Add(new OrderItem { Item = item, Quantity = quantity});
        }

        public List<OrderItem> GetOrderItems() => _orderItems;

        public decimal GetSubtotal() => _orderItems.Sum(o => o.TotalPrice);
    }
}
