using Day05.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;

namespace Day05.IOS.Views
{
    public partial class SecondView : MvxViewController
    {
        public SecondView() : base("SecondView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<SecondView, SecondViewModel>();
            set.Bind(Text1).To(vm => vm.Name);
            set.Apply();
        }
    }
}