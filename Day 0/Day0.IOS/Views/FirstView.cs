using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;

namespace Day0.IOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
            set.Bind(FirstName).To(vm => vm.FirstName);
            set.Bind(LastName).To(vm => vm.LastName);
            set.Bind(FullName).To(vm => vm.FullName);
            set.Apply();
        }
    }
}