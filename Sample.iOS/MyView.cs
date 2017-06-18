using Foundation;
using System;
using UIKit;

namespace Sample.iOS
{
    public partial class MyView : UIView
    {
        public MyView (IntPtr handle) : base (handle)
        {
        }

		public override void AwakeFromNib()
		{
			base.AwakeFromNib();
			// On définit le titre de notre bouton.
			MonBouton.SetTitle("Vue designé par XIB", UIControlState.Normal);
		}


        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
        }
    }
}