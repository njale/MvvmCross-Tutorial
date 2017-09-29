using Android.App;
using Android.OS;
using Android.Widget;
using Day25.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;

namespace Day25.Droid.Views
{
    [Activity(Label = "View for MainViewModel")]
#pragma warning disable CS0618 // Type or member is obsolete
    public class MainView : MvxTabActivity
#pragma warning restore CS0618 // Type or member is obsolete
    {
        protected MainViewModel MainViewModel => ViewModel as MainViewModel;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
            AddTab(MainViewModel.Child1, "Child1", "1");
            AddTab(MainViewModel.Child2, "Child2", "2");
            AddTab(MainViewModel.Child3, "Child3", "3");

        }

        private void AddTab(MvxViewModel viewModel, string tag, string tabText)
        {
            TabHost.TabSpec spec = TabHost.NewTabSpec(tag);
            spec.SetIndicator(tabText);
            spec.SetContent(this.CreateIntentFor(viewModel));
            TabHost.AddTab(spec);
        }
    }

    [Activity(Label = "View for Child1ViewModel")]
    public class Child1View : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Child1View);
        }
    }

    [Activity(Label = "View for Child2ViewModel")]
    public class Child2View : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Child2View);
        }
    }

    [Activity(Label = "View for Child3ViewModel")]
    public class Child3View : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Child3View);
        }
    }

    [Activity(Label = "View for GrandChildViewModel")]
    public class GrandChildView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.GrandChildView);
        }
    }
}
