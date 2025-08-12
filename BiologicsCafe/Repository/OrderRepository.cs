using BiologicsCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiologicsCafe.Repository
{
    
    public class OrderRepository : IOrderRepository
    {
        private readonly IList<OrderItem> _orderItems;

        public OrderRepository()
        {
            _orderItems = new List<OrderItem>();
        }
        public IList<OrderItem> GetOrders() => _orderItems;
              
        public void AddOrderItem(OrderItem orderItem) => _orderItems.Add(orderItem);
        public decimal GetSubtotalOrderItem() => _orderItems.Sum(o => o.TotalPrice);

        public void UpdateQuantity(MenuItem menuItem, int Quantity)
        {
            var orderItem = _orderItems.FirstOrDefault(o => o.Item.Name == menuItem.Name);
            if (orderItem != null)
            {
                orderItem.Quantity += Quantity;
            }
        }
    }
}
