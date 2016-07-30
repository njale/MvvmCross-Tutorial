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

namespace Day1.IOS.Views
{
    [Register ("FirstView")]
    partial class FirstView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider Generosity { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField SubTotal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Tip { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Total { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Generosity != null) {
                Generosity.Dispose ();
                Generosity = null;
            }

            if (SubTotal != null) {
                SubTotal.Dispose ();
                SubTotal = null;
            }

            if (Tip != null) {
                Tip.Dispose ();
                Tip = null;
            }

            if (Total != null) {
                Total.Dispose ();
                Total = null;
            }
        }
    }
}