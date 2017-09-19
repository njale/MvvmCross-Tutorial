using Foundation;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;
using UIKit;

namespace Day24.iOS.Views
{
    [Register("RedView")]
    public class RedView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var presenter = Mvx.Resolve<IMvxIosViewPresenter>();

            if (presenter.GetType() != typeof(SplitPresenter))
                NavigationController.NavigationBarHidden = false;
            View.BackgroundColor = UIColor.Red;
        }
    }
}