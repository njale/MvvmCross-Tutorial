using System;
using Day11.Core.Services;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace Day11.IOS.Views
{
    public partial class KittenCollectionCell : MvxCollectionViewCell
    {
        public static readonly NSString Key = new NSString("KittenCollectionCell");
        public static readonly UINib Nib;

        private readonly MvxImageViewLoader _imageViewLoader;
        static KittenCollectionCell()
        {
            Nib = UINib.FromName("KittenCollectionCell", NSBundle.MainBundle);
        }

        protected KittenCollectionCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
            _imageViewLoader = new MvxImageViewLoader(() => Image);

            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<KittenCollectionCell, Kitten>();
                set.Bind(Name).To(kitten => kitten.Name);
                set.Bind(Price).To(kitten => kitten.Price);
                set.Bind(_imageViewLoader).To(kitten => kitten.ImageUrl);
                set.Apply();
            });
        }
    }
}