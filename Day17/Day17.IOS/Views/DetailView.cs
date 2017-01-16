using Day17.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;

namespace Day17.IOS.Views
{
    public partial class DetailView : MvxViewController
    {
        public DetailView() : base("DetailView", null)
        {
        }

        private MvxImageViewLoader _imageViewLoader;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _imageViewLoader = new MvxImageViewLoader(() => MainImageView);

            // Perform any additional setup after loading the view, typically from a nib.

            var set = this.CreateBindingSet<DetailView, DetailViewModel>();
            set.Bind(CaptionLabel).To(vm => vm.Item.Caption);
            set.Bind(NotesLabel).To(vm => vm.Item.Notes);
            set.Bind(LocationLabel).To(vm => vm.Item).WithConversion("ItemConversion");
            set.Bind(_imageViewLoader).To(vm => vm.Item.ImagePath);
            set.Bind(DateTimeLabel).To(vm => vm.Item.WhenUtc).WithConversion("TimeAgo");
            set.Bind(DeleteButton).To(vm => vm.DeleteCommand);

            set.Apply();
        }
    }
}