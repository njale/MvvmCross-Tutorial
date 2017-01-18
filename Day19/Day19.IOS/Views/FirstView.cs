using Day19.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using UIKit;

namespace Day19.IOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var picker = new UIPickerView();
            var pickerViewModel = new MvxPickerViewModel(picker);
            picker.Model = pickerViewModel;
            picker.ShowSelectionIndicator = true;
            TextField.InputView = picker;

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(Label).To(vm => vm.Shape);
            set.Bind(ShapeLabel).For(s => s.TheShape).To(vm => vm.Shape);
            set.Bind(TextField).To(vm => vm.Shape);
            set.Bind(ShapeView).For(s => s.TheShape).To(vm => vm.Shape);
            set.Bind(pickerViewModel).For(p => p.ItemsSource).To(vm => vm.List);
            set.Bind(pickerViewModel).For(p => p.SelectedItem).To(vm => vm.Shape);
            set.Apply();

            var gestureRecognizer = new UITapGestureRecognizer(() => TextField.ResignFirstResponder());
            View.AddGestureRecognizer(gestureRecognizer);
        }
    }
}
