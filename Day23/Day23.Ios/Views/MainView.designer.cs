// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Day23.Ios.Views
{
    [Register ("MainView")]
    partial class MainView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ActualDate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Another { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView AView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Hello { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIDatePicker TheDate { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ActualDate != null) {
                ActualDate.Dispose ();
                ActualDate = null;
            }

            if (Another != null) {
                Another.Dispose ();
                Another = null;
            }

            if (AView != null) {
                AView.Dispose ();
                AView = null;
            }

            if (Hello != null) {
                Hello.Dispose ();
                Hello = null;
            }

            if (TheDate != null) {
                TheDate.Dispose ();
                TheDate = null;
            }
        }
    }
}