// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Day08.IOS.Views
{
    [Register ("FirstView")]
    partial class FirstView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel DescriptionLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Latitude { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Longtitude { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DescriptionLabel != null) {
                DescriptionLabel.Dispose ();
                DescriptionLabel = null;
            }

            if (Latitude != null) {
                Latitude.Dispose ();
                Latitude = null;
            }

            if (Longtitude != null) {
                Longtitude.Dispose ();
                Longtitude = null;
            }
        }
    }
}