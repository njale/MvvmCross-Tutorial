using Android.App;
using Android.OS;
using Day26.Core.ViewModels;
using MvvmCross.Droid.Support.V4;

namespace Day26.Droid.Views
{
    [Activity(Label = "View for HomeViewModel")]
    public class HomeView : MvxFragmentActivity<HomeViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.HomeView);
        }
    }
}