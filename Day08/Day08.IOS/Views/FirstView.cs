using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;

namespace Day08.IOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.

            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
            set.Bind(Latitude).To(vm => vm.Latitude);
            set.Bind(Longtitude).To(vm => vm.Longtitude);
            set.Apply();
        }
    }
}

