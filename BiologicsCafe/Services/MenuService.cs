using BiologicsCafe.Models;
using BiologicsCafe.Repository;

namespace BiologicsCafe.Services
{
    public class MenuService
    {
        private readonly IMenuRepository _menuRepository;
        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public IEnumerable<MenuItem> GetMenu => _menuRepository.GetMenuItems();
        public void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            foreach (MenuItem item in GetMenu)
                Console.WriteLine($"{item.Name}({item.Type}) - {item.Price}");
        }           
        
    }
}
