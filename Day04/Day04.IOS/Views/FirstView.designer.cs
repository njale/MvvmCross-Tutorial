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

namespace Day04.IOS.Views
{
    [Register ("FirstView")]
    partial class FirstView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField editText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel firstLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel forthLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel secondLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel thirdLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (editText != null) {
                editText.Dispose ();
                editText = null;
            }

            if (firstLabel != null) {
                firstLabel.Dispose ();
                firstLabel = null;
            }

            if (forthLabel != null) {
                forthLabel.Dispose ();
                forthLabel = null;
            }

            if (secondLabel != null) {
                secondLabel.Dispose ();
                secondLabel = null;
            }

            if (thirdLabel != null) {
                thirdLabel.Dispose ();
                thirdLabel = null;
            }
        }
    }
}