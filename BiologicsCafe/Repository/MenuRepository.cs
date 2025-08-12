using BiologicsCafe.Models;

namespace BiologicsCafe.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly List<MenuItem> _menuItems = new() {
                new MenuItem { Name = "BBQ Chicken Toastie", Type = ItemType.Food, Price = 6.23m },
                new MenuItem { Name = "Ham and Cheese Toastie", Type = ItemType.Food, Price = 5.78m },
                new MenuItem { Name = "Chocolate Brownie", Type = ItemType.Food, Price = 3.50m },
                new MenuItem { Name = "Tea", Type = ItemType.Drink, Price = 3.65m },
                new MenuItem { Name = "Coffee", Type = ItemType.Drink, Price = 4.64m },
                new MenuItem { Name = "Water", Type = ItemType.Drink, Price = 0.00m }
            };
        public IEnumerable<MenuItem> GetMenuItems() => _menuItems;
        
    }
}
