using BiologicsCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiologicsCafe.Services.Discount
{
    public class DiscountCalculator
    {
        private readonly IDiscountStrategy _strategy;
        public DiscountCalculator()
        {
            List<IDiscountStrategy> stratgiesList = new()
            {
                new FoodAndDrinkDiscount(),
                new SpendThresholdDiscount(),
            };
            var bestStrategy = new BestDiscountSelectorStrategy(stratgiesList);
            _strategy = new MaxDiscountStrategy(bestStrategy);
        }
        public decimal CalculateDiscount(IList<OrderItem> orderItems)
        {
            return _strategy.Calculate(orderItems);
        }
    }
}
