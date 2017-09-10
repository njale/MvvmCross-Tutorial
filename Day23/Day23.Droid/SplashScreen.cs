using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace Day23.Droid
{
    [Activity(
        Label = "Day23.Droid"
        , MainLauncher = true
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen() : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
