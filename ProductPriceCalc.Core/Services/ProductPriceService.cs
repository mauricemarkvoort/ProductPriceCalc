using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPriceCalc.Core.Services
{
    class ProductPriceService
        : IProductPriceService
    {
        public double CalculatePrize(double retailPrice, double tax, double profit)
        {
            tax = (tax + 100) / 100;
            profit = (profit + 100) / 100;
            return retailPrice * tax * profit;
        }
    }
}
