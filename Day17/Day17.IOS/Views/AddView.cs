using Day17.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace Day17.IOS.Views
{
    public partial class AddView : MvxViewController
    {
        public AddView() : base("AddView", null)
        {
        }
        
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            var set = this.CreateBindingSet<AddView, AddViewModel>();
            set.Bind(CaptionText).To(vm => vm.Caption);
            set.Bind(NotesText).To(vm => vm.Notes);
            set.Bind(AddPictureButton).To(vm => vm.AddPictureCommand);
            set.Bind(SaveButton).To(vm => vm.SaveCommand);
            set.Bind(LocationSwitch).To(vm => vm.LocationKnown);
            set.Bind(MainImageView).To(vm => vm.PictureBytes).WithConversion("InMemoryImage");

            set.Apply();

            var gesture = new UITapGestureRecognizer(() =>
            {
                CaptionText.ResignFirstResponder();
                NotesText.ResignFirstResponder();
            });

            View.AddGestureRecognizer(gesture);
        }
    }
}