using Day24.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform.Platform;
using UIKit;
using MvvmCross.iOS.Views;
using MvvmCross.Platform;

namespace Day24.iOS
{

    // REMEMBER: Set MainInterface in Info.plist (otherwise gray screen)
    public class Setup : MvxIosSetup
    {
        private UIWindow _window;

        public Setup(IMvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
            _window = window;
            UIDevice.CurrentDevice.BeginGeneratingDeviceOrientationNotifications();
        }

        public Setup(IMvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override IMvxIosViewPresenter CreatePresenter()
        {
            if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad && (
                UIApplication.SharedApplication.StatusBarOrientation != UIInterfaceOrientation.Portrait &&
                UIApplication.SharedApplication.StatusBarOrientation != UIInterfaceOrientation.PortraitUpsideDown))
                return new SplitPresenter(_window);
            else
                return base.CreatePresenter();
        }
    }


    public class SplitPresenter : MvxBaseIosViewPresenter
    {
        private SplitViewController _splitViewController;

        public SplitPresenter(UIWindow window)
        {
            _splitViewController = new SplitViewController();
            window.RootViewController = _splitViewController;
        }

        public override void Show(MvxViewModelRequest request)
        {
            var viewController = (UIViewController)Mvx.Resolve<IMvxIosViewCreator>().CreateView(request);

            if (request.ViewModelType == typeof(FirstViewModel))
            {
                _splitViewController.SetLeft(viewController);
            }
            else
            {
                _splitViewController.SetRight(viewController);
            }

        }
    }


    public class SplitViewController : UISplitViewController
    {
        public SplitViewController()
        {
            ViewControllers = new UIViewController[]
            {
                new UIViewController(),
                new UIViewController()
            };
        }

        public void SetLeft(UIViewController left)
        {
            ViewControllers = new UIViewController[]
            {
                left,
                ViewControllers[1],
            };
        }

        public void SetRight(UIViewController right)
        {
            ViewControllers = new UIViewController[]
            {
                ViewControllers[0],
                right
            };
        }
    }
}
