using Android.App;
using Android.OS;
using CrossUI.Droid.Dialog.Elements;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Dialog.Droid.Views;

namespace Day23.Droid.Views
{
    [Activity(Label = "View for MainViewModel")]
    public class MainView : MvxDialogActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
			// SetContentView(Resource.Layout.MainView);

			Root = new RootElement("The Dialog")
			{
				new Section("Strings")
				{
					new EntryElement("Hello").Bind(this, "Value Hello"),
					new EntryElement("Another").Bind(this, "Value Another"),
					new StringElement("Test").Bind(this, "Value Combined"),
					new BooleanElement("T or F", false).Bind(this, "Value Option1"),
					new StringElement("T or F").Bind(this, "Value Option1")
				},
				new Section("Dates")
				{
					new DateElement("The Date").Bind(this, "Value TheDate"),
					new StringElement("Actual").Bind(this, "Value TheDate")
				}
			};
		}
    }
}
