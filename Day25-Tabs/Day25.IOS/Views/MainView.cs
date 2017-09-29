using System.Drawing;
using Day25.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using UIKit;
using ObjCRuntime;
using System;

namespace Day25.IOS.Views
{
    public sealed partial class MainView : MvxTabBarViewController
    {
        public MainView()
        {
            // Need this additional call to ViewDidLoad because UIkit creates the view before thr C# hierarchy has been constructed
            ViewDidLoad();
        }

        MainViewModel MainViewModel => ViewModel as MainViewModel;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib
            // ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
                EdgesForExtendedLayout = UIRectEdge.None;

            // Can get here before ViewModel has been crated, hence the extra call in constructor
            if (ViewModel != null)
            {
                var viewControllers = new[]
                {
                    CreateTab("Welcome", "home", MainViewModel.Child1),
                    CreateTab("To", "twitter", MainViewModel.Child2),
                    CreateTab("My", "favorites", MainViewModel.Child3)
                };

                ViewControllers = viewControllers;
                CustomizableViewControllers = new UIViewController[] { };
                SelectedViewController = ViewControllers[0];
            }
        }

        private int _createdTabsCount = 0;

        private UIViewController CreateTab(string title, string imageName, IMvxViewModel viewModel)
        {
            var controller = new UINavigationController();
            controller.NavigationBar.TintColor = UIColor.Blue;
            var screen = this.CreateViewControllerFor(viewModel) as UIViewController;
            SetTitleAndTabBarItem(screen, title, imageName);
            controller.PushViewController(screen, false);
            return controller;
        }

        internal void ShowGrandChild(IMvxIosView view)
        {
            var currentNav = SelectedViewController as UINavigationController;
            currentNav.PushViewController(view as UIViewController, true);
        }

        private void SetTitleAndTabBarItem(UIViewController screen, string title, string imageName)
        {
            screen.Title = title;
            screen.TabBarItem = new UITabBarItem(title, UIImage.FromBundle("Images/Tabs/" + imageName + ".png"), _createdTabsCount);
            _createdTabsCount++;
        }
    }

    public class Child1View : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView() { BackgroundColor = UIColor.DarkGray };
            base.ViewDidLoad();

            NavigationItem.BackBarButtonItem = new UIBarButtonItem(){Title = "Kid 1"};

            var label = new UILabel(new RectangleF(10, 70, 300, 40));
            Add(label);

            var button = new UIButton(UIButtonType.RoundedRect);
            button.Frame = new RectangleF(10, 100, 300, 40);
            button.SetTitle("Go", UIControlState.Normal);
            Add(button);


            this.CreateBinding(label).To<Child1ViewModel>(vm => vm.Foo).Apply();
            this.CreateBinding(button).To<Child1ViewModel>(vm => vm.GoCommand).Apply();
        }
    }

    public class Child2View : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView() { BackgroundColor = UIColor.Magenta };
            base.ViewDidLoad();

            var label = new UILabel(new RectangleF(10, 70, 300, 40));
            Add(label);

            this.CreateBinding(label).To<Child2ViewModel>(vm => vm.Bar).Apply();
        }
    }

    public class Child3View : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView() { BackgroundColor = UIColor.Orange };
            base.ViewDidLoad();

            var label = new UILabel(new RectangleF(10, 70, 300, 40));
            Add(label);

            this.CreateBinding(label).To<Child3ViewModel>(vm => vm.Oink).Apply();
        }
    }

    public class GrandChildView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView() { BackgroundColor = UIColor.Red };
            base.ViewDidLoad();

            Title = "Grand child";

            var label = new UILabel(new RectangleF(10, 70, 300, 40));
            Add(label);

            this.CreateBinding(label).To<GrandChildViewModel>(vm => vm.Life).Apply();
        }
    }
}