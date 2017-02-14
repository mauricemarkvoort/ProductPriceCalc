using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPriceCalc.Core.Services
{
    public interface IProductPriceService
    {
        double CalculatePrize(double retailPrice, double tax, double profit);
    }
}
