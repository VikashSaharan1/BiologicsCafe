using BiologicsCafe.Models;
using BiologicsCafe.Repository;
using BiologicsCafe.Services;
using Moq;


namespace BiologicsCafe.Tests.Services
{
    public class MenuServiceTests
    {
        [Fact]
        public void GetMenuItems()
        {
            var mockRepo = new Mock<IMenuRepository>();
            mockRepo.Setup(mr => mr.GetMenuItems())
                .Returns(new[] {
                new MenuItem { Name = "BBQ Chicken Toastie", Type = ItemType.Food, Price = 6.23m },
                new MenuItem { Name = "Ham and Cheese Toastie", Type = ItemType.Food, Price = 5.78m },
                new MenuItem { Name = "Chocolate Brownie", Type = ItemType.Food, Price = 3.50m },
                new MenuItem { Name = "Tea", Type = ItemType.Drink, Price = 3.65m },
                new MenuItem { Name = "Coffee", Type = ItemType.Drink, Price = 4.64m },
                new MenuItem { Name = "Water", Type = ItemType.Drink, Price = 0.00m }
            });

            var service = new MenuService(mockRepo.Object);
            var result = service.GetMenu;

            //Assertion
            Assert.Equal(6, result.Count());
            Assert.Contains(result, item => item.Name == "Tea");

        }
    }
}
