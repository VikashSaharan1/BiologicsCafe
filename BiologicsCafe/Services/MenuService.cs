using BiologicsCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiologicsCafe.Services
{
    public class MenuService
    {
        private readonly List<MenuItem> _menuItems;
        public MenuService()
        {
            _menuItems = new() {
                new MenuItem { Name = "BBQ Chicken Toastie", Type = ItemType.Food, Price = 6.23m },
                new MenuItem { Name = "Ham and Cheese Toastie", Type = ItemType.Food, Price = 5.78m },
                new MenuItem { Name = "Chocolate Brownie", Type = ItemType.Food, Price = 3.50m },
                new MenuItem { Name = "Tea", Type = ItemType.Drink, Price = 3.65m },
                new MenuItem { Name = "Coffee", Type = ItemType.Drink, Price = 4.64m },
                new MenuItem { Name = "Water", Type = ItemType.Drink, Price = 0.00m }
            };
        }

        public List<MenuItem> GetMenu => _menuItems;
        public void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            foreach (MenuItem item in _menuItems)
                Console.WriteLine($"{item.Name}({item.Type}) - {item.Price}");
        }           
        
    }
}
