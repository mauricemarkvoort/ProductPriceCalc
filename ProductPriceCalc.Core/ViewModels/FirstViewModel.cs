using MvvmCross.Core.ViewModels;
using ProductPriceCalc.Core.Services;

namespace ProductPriceCalc.Core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private readonly IProductPriceService _productPriceService;

        public FirstViewModel(IProductPriceService productPriceService)
        {
            _productPriceService = productPriceService;
            _retailPrice = 0.00;
            _tax = 21;
            _profit = 10;
        }

        private double _retailPrice;
        public double RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; RaisePropertyChanged(() => RetailPrice); Recalc(); }
        }

        private double _tax;
        public double Tax
        {
            get { return _tax; }
            set { _tax = value; RaisePropertyChanged(() => Tax); Recalc(); }
        }

        private double _profit;
        public double Profit
        {
            get { return _profit; }
            set { _profit = value; RaisePropertyChanged(() => Profit); Recalc(); }
        }

        private double _totalPrice;
        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; RaisePropertyChanged(() => TotalPrice); }
        }

        private void Recalc()
        {
            TotalPrice = _productPriceService.CalculatePrize(RetailPrice, Tax, Profit);
        }
    }
}
