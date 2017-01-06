using System;
using Day11.Core.Services;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace Day11.IOS.Views
{
    public partial class KittenCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("KittenCell");
        public static readonly UINib Nib;

        private readonly MvxImageViewLoader _imageViewLoader;

        static KittenCell()
        {
            Nib = UINib.FromName("KittenCell", NSBundle.MainBundle);
        }

        protected KittenCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
            _imageViewLoader = new MvxImageViewLoader(() => MainImage);

            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<KittenCell, Kitten>();
                
                set.Bind(NameLabel).To(kitten => kitten.Name);
                set.Bind(PriceLabel).To(kitten => kitten.Price);
                set.Bind(_imageViewLoader).To(kitten => kitten.ImageUrl);
                set.Apply();
            });
        }
    }
}
