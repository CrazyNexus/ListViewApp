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

namespace ListViewApp
{
    [Register ("CustomCell")]
    partial class CustomCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel headingLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel subHeadingLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (headingLabel != null) {
                headingLabel.Dispose ();
                headingLabel = null;
            }

            if (subHeadingLabel != null) {
                subHeadingLabel.Dispose ();
                subHeadingLabel = null;
            }
        }
    }
}