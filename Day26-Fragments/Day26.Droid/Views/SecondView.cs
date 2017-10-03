using Android.App;
using Android.OS;
using Android.Widget;
using Day26.Core.ViewModels;
using MvvmCross.Droid.Support.V4;

namespace Day26.Droid.Views
{
    [Activity(Label = "View for SecondViewModel")]
    public class SecondView : MvxFragmentActivity<SecondViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SecondView);

            var subFrag = new SubFrag {ViewModel = ViewModel.Sub};
            var dubFrag = new DubFrag { ViewModel = ViewModel.Sub };

            var trans = SupportFragmentManager.BeginTransaction();
            trans.Replace(Resource.Id.subframe1, subFrag);
            trans.Commit();

            var trans2 = SupportFragmentManager.BeginTransaction();
            trans2.Replace(Resource.Id.dubframe1, dubFrag);
            trans2.Commit();

            var but1 = FindViewById<Button>(Resource.Id.but1);
            var but2 = FindViewById<Button>(Resource.Id.but2);

            but1.Click += (sender, args) => { OnClick_SwapFragments(); };
            but2.Click += (sender, args) => { OnClick_SwapFragments(); };
        }

        private void OnClick_SwapFragments()
        {
            var dNew = new DubFrag
            {
                ViewModel = ViewModel.Sub
            };

            var sNew = new SubFrag
            {
                ViewModel = ViewModel.Sub
            };

            var trans3 = SupportFragmentManager.BeginTransaction();

            var sub = SupportFragmentManager.FindFragmentById(Resource.Id.subframe1);
            if (sub.GetType() == typeof(SubFrag))
            {
                trans3.Replace(Resource.Id.subframe1, dNew);
                trans3.Replace(Resource.Id.dubframe1, sNew);
            }
            else
            {
                trans3.Replace(Resource.Id.subframe1, sNew);
                trans3.Replace(Resource.Id.dubframe1, dNew);
            }

            trans3.AddToBackStack(null);

            trans3.Commit();
        }
    }
}