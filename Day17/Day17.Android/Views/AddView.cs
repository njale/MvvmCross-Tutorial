using System;
using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Day17.Android.Views
{
    [Activity(Label = "Add")]
    public class AddView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            try
            {
                base.OnCreate(bundle);
                SetContentView(Resource.Layout.AddView);
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
    }
}