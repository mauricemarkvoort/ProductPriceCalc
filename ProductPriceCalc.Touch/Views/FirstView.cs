using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using ProductPriceCalc.Core.ViewModels;
using System.Drawing;
using UIKit;

namespace ProductPriceCalc.iOS.Views
{
    public partial class FirstView : MvxViewController<FirstViewModel>
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var labelRetail = new UILabel(new RectangleF(10, 10, 300, 40));
            labelRetail.Text = "Retail price";
            Add(labelRetail);

            var retailPriceField = new UITextField(new Rectangle(10, 50, 300, 40));
            Add(retailPriceField);

            var label1 = new UILabel(new RectangleF(10, 90, 300, 40));
            label1.Text = "Tax";
            Add(label1);

            var sliderTax = new UISlider(new Rectangle(10, 130, 300, 40));
            sliderTax.MinValue = 0;
            sliderTax.MaxValue = 100;
            Add(sliderTax);

            var labelTax = new UILabel(new RectangleF(10, 170, 300, 40));
            Add(labelTax);

            var label2 = new UILabel(new RectangleF(10, 210, 300, 40));
            label2.Text = "Profit";
            Add(label2);

            var sliderProfit = new UISlider(new Rectangle(10, 250, 300, 40));
            sliderProfit.MinValue = 0;
            sliderProfit.MaxValue = 100;
            Add(sliderProfit);

            var labelProfit = new UILabel(new RectangleF(10, 290, 300, 40));
            Add(labelProfit);

            var labelTotal = new UILabel(new RectangleF(10, 330, 300, 40));
            Add(labelTotal);

            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
            set.Bind(retailPriceField).To(vm => vm.RetailPrice);
            set.Bind(sliderTax).To(vm => vm.Tax);
            set.Bind(labelTax).To(vm => vm.Tax);
            set.Bind(sliderProfit).To(vm => vm.Profit);
            set.Bind(labelProfit).To(vm => vm.Profit);
            set.Bind(labelTotal).To(vm => vm.TotalPrice);
            set.Apply();
        }
    }
}
