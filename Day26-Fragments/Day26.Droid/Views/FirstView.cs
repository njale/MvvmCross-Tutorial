using Android.App;
using Android.OS;
using Day26.Core.ViewModels;
using MvvmCross.Droid.Support.V4;

namespace Day26.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxFragmentActivity<FirstViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);

            var sub = (SubFrag)SupportFragmentManager.FindFragmentById(Resource.Id.sub1);
            sub.ViewModel = ViewModel.Sub;

            var dub = (DubFrag)SupportFragmentManager.FindFragmentById(Resource.Id.dub1);
            dub.ViewModel = ViewModel.Sub;

        }
    }
}
