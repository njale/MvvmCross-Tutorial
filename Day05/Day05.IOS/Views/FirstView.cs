using Day05.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;

namespace Day05.IOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(Label1).To(vm => vm.Hello);
            set.Bind(Text1).To(vm => vm.Hello);
            set.Bind(Button1).To(vm => vm.MyCommand);
            set.Bind(Button2).To(vm => vm.GoSecondCommand);
            set.Apply();
        }
        
    }
}