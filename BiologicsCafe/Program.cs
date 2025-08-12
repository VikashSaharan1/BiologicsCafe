using BiologicsCafe.Repository;
using BiologicsCafe.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BiologicsCafe
{
    public class Program
    {
        static void Main(string[] args)
        {
           var serviceProvider = new ServiceCollection()
           .AddSingleton<IMenuRepository, MenuRepository>()
           .AddScoped<IOrderRepository, OrderRepository>()
           .AddTransient<MenuService>()
           .AddTransient<OrderService>() 
           .BuildServiceProvider();

            var menuService = serviceProvider.GetRequiredService<MenuService>();
            var orderService = serviceProvider.GetRequiredService<OrderService>();
            var discountService = new DiscountService();

            menuService.DisplayMenu();
            Console.WriteLine("\n Starting ordering (type 'done' to finish):");

            var menu = menuService.GetMenu;
            while (true)
            {
                Console.Write("\nEnter item name: ");
                var input = Console.ReadLine()?.Trim().ToLower();

                if (input == "done") break;

                var item = menu.FirstOrDefault(mi => mi.Name.Equals(input, StringComparison.OrdinalIgnoreCase));
                if (item == null)
                {
                    Console.WriteLine("Item not Found. Please try again.");
                    continue;
                }
                
                
                Console.Write("Enter quantity: ");
                if (!int.TryParse(Console.ReadLine(), out int qty) || qty <= 0)
                {
                    Console.WriteLine("Invalid quantity");
                    continue;
                }
                

                orderService.AddOrder(item, qty);
                Console.WriteLine($"Added Order Item: {item.Name} x {qty}");
            }

            var orderItems = orderService.GetOrderItems();
            var subtotal = orderService.GetSubtotal();
            var discount = discountService.calculateDiscount(orderItems);
            var total = subtotal - discount;

            Console.WriteLine("\nFinal Invoice");
            foreach (var item in orderItems)
                Console.WriteLine($"{item.Item.Name}(£{item.Item.Price}) x {item.Quantity} = £{item.TotalPrice}");

            Console.WriteLine($"SubTotal: £{subtotal:F2}");
            Console.WriteLine($"Discount: £{discount:F2}");
            Console.WriteLine($"Total: £{total:F2}");
        }
    }
}
