using BiologicsCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiologicsCafe.Services.Discount
{
    public interface IDiscountStrategy
    {
        decimal Calculate(IList<OrderItem> orders);
    }
}
