using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace Day25.Droid
{
    [Activity(
        Label = "Day25.Droidern"
        , MainLauncher = true
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
