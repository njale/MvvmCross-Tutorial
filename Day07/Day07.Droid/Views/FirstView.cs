using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Day07.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);

            // Binding properties can be found under Android.Widget.<C
            // Android.Widget.EditText e;
            // e.Enabled = bla.bla;
        }
    }
}
