// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//

using System.CodeDom.Compiler;
using Foundation;

namespace Day03.IOS.Views
{
    [Register ("KittenCell")]
    partial class KittenCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView MainImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel NameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PriceLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (MainImage != null) {
                MainImage.Dispose ();
                MainImage = null;
            }

            if (NameLabel != null) {
                NameLabel.Dispose ();
                NameLabel = null;
            }

            if (PriceLabel != null) {
                PriceLabel.Dispose ();
                PriceLabel = null;
            }
        }
    }
}