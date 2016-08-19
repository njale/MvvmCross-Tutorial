using System;
using Day065.Core.Model;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace Day065.IOS.Views
{
    public partial class BookCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("BookCell");
        public static readonly UINib Nib;

        private readonly MvxImageViewLoader _imageViewLoader;

        static BookCell()
        {
            Nib = UINib.FromName("BookCell", NSBundle.MainBundle);
        }

        protected BookCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.

            _imageViewLoader = new MvxImageViewLoader(()=> MainImage);

            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<BookCell, BookSearchItem>();
                set.Bind(PublisherLabel).To(item => item.VolumeInfo.Publisher);
                set.Bind(TitleLabel).To(item => item.VolumeInfo.Title);
                set.Bind(_imageViewLoader).To(item => item.VolumeInfo.ImageLinks.SmallThumbnail);
                set.Apply();
            });

        }
    }
}
