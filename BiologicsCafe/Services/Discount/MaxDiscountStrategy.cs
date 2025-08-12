using BiologicsCafe.Models;

namespace BiologicsCafe.Services.Discount
{
    public class MaxDiscountStrategy: IDiscountStrategy
    {
        private readonly IDiscountStrategy _discountStrategy;
        private decimal _maxCap;
        public MaxDiscountStrategy(IDiscountStrategy discountStrategy, decimal maxCap)
        {
            _discountStrategy = discountStrategy;
            _maxCap = maxCap;
        }

        public decimal Calculate(List<OrderItem> orders)
        {
            return Math.Min(_discountStrategy.Calculate(orders), _maxCap);
        }
    }
}
