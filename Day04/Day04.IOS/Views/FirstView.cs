using System;
using Day04.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace Day04.IOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

       
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(editText).To(vm => vm.Foo);
            set.Bind(firstLabel).To(vm => vm.Foo);
            set.Bind(secondLabel).To(vm => vm.Foo).WithConversion("StringLength");
            set.Bind(thirdLabel).To(vm => vm.Foo).WithConversion("StringReverse");
            set.Bind(forthLabel).To(vm => vm.Foo).WithConversion("Special");

            set.Apply();
        }
    }
}