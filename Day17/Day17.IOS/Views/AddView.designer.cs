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
    [Register ("AddView")]
    partial class AddView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AddPictureButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField CaptionText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch LocationSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView MainImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField NotesText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SaveButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AddPictureButton != null) {
                AddPictureButton.Dispose ();
                AddPictureButton = null;
            }

            if (CaptionText != null) {
                CaptionText.Dispose ();
                CaptionText = null;
            }

            if (LocationSwitch != null) {
                LocationSwitch.Dispose ();
                LocationSwitch = null;
            }

            if (MainImageView != null) {
                MainImageView.Dispose ();
                MainImageView = null;
            }

            if (NotesText != null) {
                NotesText.Dispose ();
                NotesText = null;
            }

            if (SaveButton != null) {
                SaveButton.Dispose ();
                SaveButton = null;
            }
        }
    }
}