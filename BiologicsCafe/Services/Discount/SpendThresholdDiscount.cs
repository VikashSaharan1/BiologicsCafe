using BiologicsCafe.Models;

namespace BiologicsCafe.Services.Discount
{
    public class SpendThresholdDiscount : IDiscountStrategy
    {
        public decimal Calculate(List<OrderItem> orderItems)
        {
            decimal subtotal = orderItems.Sum(o => o.TotalPrice);
            decimal discount = subtotal >= 20.0m ? subtotal : 0;
            return discount;
        }
    }
}
