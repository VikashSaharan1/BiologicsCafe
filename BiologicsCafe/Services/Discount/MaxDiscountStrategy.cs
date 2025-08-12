using BiologicsCafe.Models;

namespace BiologicsCafe.Services.Discount
{
    public class MaxDiscountStrategy: IDiscountStrategy
    {
        private readonly IDiscountStrategy _discountStrategy;
        private decimal _maxCap;
        public MaxDiscountStrategy(IDiscountStrategy discountStrategy, decimal maxCap = 6.0m)
        {
            _discountStrategy = discountStrategy;
            _maxCap = maxCap;
        }

        public decimal Calculate(IList<OrderItem> orders)
        {
            return Math.Min(_discountStrategy.Calculate(orders), _maxCap);
        }
    }
}
