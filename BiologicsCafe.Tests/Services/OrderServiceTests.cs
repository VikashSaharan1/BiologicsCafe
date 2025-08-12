using BiologicsCafe.Models;
using BiologicsCafe.Repository;
using BiologicsCafe.Services;
using Moq;
using System.Diagnostics;
using System.Xml.Linq;


namespace BiologicsCafe.Tests.Services
{
    public class OrderServiceTests
    {
        [Fact]
        public void GetOrders_IfFound()
        {
            var menuItem = new MenuItem() { Name = "BBQ Chicken Toastie", Type = ItemType.Food, Price = 6.23m };
            var mockRepo = new Mock<IOrderRepository>();
            mockRepo.Setup(r => r.GetOrders())
            .Returns(new List<OrderItem>
            {
                    new OrderItem {
                        Item = menuItem,
                        Quantity = 1
                    } 
            });
            var service = new OrderService(mockRepo.Object);

            Assert.Equal(service.GetOrderItems().Count, 1);
          

        }

    }
}
