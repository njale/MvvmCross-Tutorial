using System;
using System.Drawing;
using Day24.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;
using UIKit;

namespace Day24.iOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            View = new UIView {BackgroundColor = UIColor.White};

            base.ViewDidLoad();
            var buttonBlue = new UIButton(UIButtonType.RoundedRect) { Frame = new RectangleF(10, 10, 300, 40) };
            buttonBlue.SetTitle("Blue", UIControlState.Normal);
            Add(buttonBlue);

            var buttonRed = new UIButton(UIButtonType.RoundedRect) { Frame = new RectangleF(10, 50, 300, 40) };
            buttonRed.SetTitle("Red", UIControlState.Normal);
            Add(buttonRed);

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(buttonBlue).To(vm => vm.BlueCommand);
            set.Bind(buttonRed).To(vm => vm.RedCommand);
            set.Apply();
        }

        public override bool BecomeFirstResponder()
        {
            var presenter = Mvx.Resolve<IMvxIosViewPresenter>();

            if (presenter.GetType() != typeof(SplitPresenter))
                NavigationController.NavigationBarHidden = true;

            return base.BecomeFirstResponder();
        }
    }
}