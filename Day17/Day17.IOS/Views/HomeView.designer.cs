// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Day17.IOS.Views
{
    [Register ("HomeView")]
    partial class HomeView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AddButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ImageHolder { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView LatestImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LatestTitleLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ListButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AddButton != null) {
                AddButton.Dispose ();
                AddButton = null;
            }

            if (ImageHolder != null) {
                ImageHolder.Dispose ();
                ImageHolder = null;
            }

            if (LatestImageView != null) {
                LatestImageView.Dispose ();
                LatestImageView = null;
            }

            if (LatestTitleLabel != null) {
                LatestTitleLabel.Dispose ();
                LatestTitleLabel = null;
            }

            if (ListButton != null) {
                ListButton.Dispose ();
                ListButton = null;
            }
        }
    }
}