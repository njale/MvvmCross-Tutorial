using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Day17.Android.Views
{
    [Activity(Label = "Detail")]
    public class DetailView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.DetailView);
        }
    }
}