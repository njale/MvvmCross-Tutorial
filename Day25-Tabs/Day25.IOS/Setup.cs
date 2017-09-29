using Day25.IOS.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform.Platform;
using UIKit;

namespace Day25.IOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(IMvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }
        
        public Setup(IMvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxIosViewPresenter CreatePresenter()
        {
            return new MyPresenter(ApplicationDelegate, Window);
        }


        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }

    public class MyPresenter : MvxIosViewPresenter
    {
        public MyPresenter(IMvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }

        protected override MvxNavigationController CreateNavigationController(UIViewController viewController)
        {
            var navBar = base.CreateNavigationController(viewController);
            navBar.NavigationBarHidden = true;
            return navBar;
        }

        private MainView _mainView;

        public override void Show(IMvxIosView view, MvxViewModelRequest request)
        {
            if (view is MainView)
            {
                _mainView = view as MainView;
            }

            if (view is GrandChildView)
            {
                if (_mainView != null)
                {
                    _mainView.ShowGrandChild(view);
                }
                return;
            }

            base.Show(view, request);
        }
    }


}
