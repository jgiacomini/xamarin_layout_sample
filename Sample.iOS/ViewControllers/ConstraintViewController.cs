using System;
using UIKit;
using Cirrious.FluentLayouts.Touch;

namespace Sample.iOS
{
    public class ConstraintViewController : UIViewController
    {
      
        public ConstraintViewController()
        {
			Title = "Les contraintes";
			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var button = UIButton.FromType(UIButtonType.System);

            button.SetTitle("Bouton", UIControlState.Normal);
            button.BackgroundColor = UIColor.Red;

			var button2 = UIButton.FromType(UIButtonType.System);
			button2.SetTitle("Bouton2", UIControlState.Normal);
			button2.BackgroundColor = UIColor.Red;
			

            View.AddSubviews(button, button2);



            nfloat vmargin = 5;
			nfloat hmargin = 5;


			View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
			View.AddConstraints(
                button.AtTopOf(View, vmargin),
                button.AtLeftOf(View, hmargin),
                button.WithSameWidth(View).Minus(2 * hmargin),
                button.Height().EqualTo(20),

                button2.Below(button, vmargin),
                button2.WithSameLeft(button),
				button2.WithSameWidth(button),
                button2.WithSameHeight(button)
			);
		}
    }
}
