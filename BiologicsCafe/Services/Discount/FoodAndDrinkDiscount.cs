using BiologicsCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiologicsCafe.Services.Discount
{
    public class FoodAndDrinkDiscount : IDiscountStrategy
    {
        public decimal Calculate(List<OrderItem> orderItems)
        {
            decimal discount = 0;
            bool hasFood = orderItems.Any(o => o.Item.Type == ItemType.Food);
            bool hasDrink = orderItems.Any(o => o.Item.Type == ItemType.Drink);

            if (hasFood && hasDrink)
            {
                decimal subtotal = orderItems.Sum(o => o.TotalPrice);
                discount += subtotal * 0.10m;
            }
            return discount;
        }
    }
}
