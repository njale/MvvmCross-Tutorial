using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace Day08.Droid
{
    [Activity(
        Label = "Day08.LabelDroid"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
