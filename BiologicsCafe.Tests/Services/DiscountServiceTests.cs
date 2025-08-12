
using BiologicsCafe.Models;
using BiologicsCafe.Services;

namespace BiologicsCafe.Tests.Services
{
    public class DiscountServiceTests
    {
        [Fact]
        public void AppliesMaxDiscount()
        {
            IList<OrderItem> items = new List<OrderItem>
            {
                new() { Item = new MenuItem { Name = "BBQ Chicken Toastie", Type = ItemType.Food, Price = 10.00m }, Quantity = 3 },
                new() { Item = new MenuItem { Name = "Coffee", Type = ItemType.Drink, Price = 5.00m }, Quantity = 1 }
            };

            var service = new DiscountService();
            var discount = service.calculateDiscount(items);

            Assert.Equal(6.0m, discount); 
        }

    }
}
