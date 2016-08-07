using System;
using Day05.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace Day05.IOS.Views
{
    public partial class ThirdView : MvxViewController
    {
        public ThirdView() : base("ThirdView", null)
        {
        }

        
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<ThirdView, ThirdViewModel>();
            set.Bind(Text1).To(vm => vm.TheAnswer);
            set.Apply();
        }
    }
}