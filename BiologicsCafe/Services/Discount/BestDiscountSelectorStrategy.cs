using BiologicsCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiologicsCafe.Services.Discount
{
    public class BestDiscountSelectorStrategy: IDiscountStrategy
    {
        private readonly List<IDiscountStrategy> _strategies;
        public BestDiscountSelectorStrategy(IEnumerable<IDiscountStrategy> strategies)
        {
            _strategies = strategies.ToList();
        }

        public decimal Calculate(List<OrderItem> orderItems)
        {
            return _strategies.Max(s => s.Calculate(orderItems));
        }
    }
}
