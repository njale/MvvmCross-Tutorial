using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Day17.Android.Views
{
    [Activity(Label = "Home")]
    public class HomeView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.HomeView);
        }
    }
}
