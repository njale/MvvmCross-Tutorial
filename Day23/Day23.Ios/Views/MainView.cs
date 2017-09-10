using MvvmCross.Binding.BindingContext;
using MvvmCross.Dialog.iOS;
using MvvmCross.iOS.Views.Presenters.Attributes;
using CrossUI.iOS.Dialog.Elements;

namespace Day23.Ios.Views
{
	[MvxRootPresentation(WrapInNavigationController = true)]
	public partial class MainView : MvxDialogViewController
	{
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

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
