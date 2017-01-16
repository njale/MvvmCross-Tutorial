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
    [Register ("DetailView")]
    partial class DetailView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel CaptionLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel DateTimeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DeleteButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LocationLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView MainImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel NotesLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CaptionLabel != null) {
                CaptionLabel.Dispose ();
                CaptionLabel = null;
            }

            if (DateTimeLabel != null) {
                DateTimeLabel.Dispose ();
                DateTimeLabel = null;
            }

            if (DeleteButton != null) {
                DeleteButton.Dispose ();
                DeleteButton = null;
            }

            if (LocationLabel != null) {
                LocationLabel.Dispose ();
                LocationLabel = null;
            }

            if (MainImageView != null) {
                MainImageView.Dispose ();
                MainImageView = null;
            }

            if (NotesLabel != null) {
                NotesLabel.Dispose ();
                NotesLabel = null;
            }
        }
    }
}