// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Sample.iOS
{
    [Register ("MyView")]
    partial class MyView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton MonBouton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (MonBouton != null) {
                MonBouton.Dispose ();
                MonBouton = null;
            }
        }
    }
}