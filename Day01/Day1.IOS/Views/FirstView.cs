using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace Day1.IOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

       
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
            set.Bind(SubTotal).To(vm => vm.SubTotal);
            set.Bind(Generosity).To(vm => vm.Generosity);
            set.Bind(Tip).To(vm => vm.Tip);
            set.Bind(Total).To(vm => vm.Total);
            set.Apply();

            var gesture = new UITapGestureRecognizer(()=> SubTotal.ResignFirstResponder());
            View.AddGestureRecognizer(gesture);
        }
    }
}