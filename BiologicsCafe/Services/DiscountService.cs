using BiologicsCafe.Models;
using BiologicsCafe.Services.Discount;

namespace BiologicsCafe.Services
{
    public class DiscountService
    {
        public decimal calculateDiscount(List<OrderItem> orderItems)
        {
            var discountCalculator = new DiscountCalculator();
            return discountCalculator.CalculateDiscount(orderItems);
        }
        
    }
}
