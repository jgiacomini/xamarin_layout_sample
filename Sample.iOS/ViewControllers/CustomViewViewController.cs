using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Sample.iOS
{
    public class CustomViewViewController : UIViewController
    {
        public CustomViewViewController()
        {
			Title = "Exemple de vue personalisée";
			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;

            var customView = new CustomView();
            customView.Frame = new CoreGraphics.CGRect(50, 50, 100, 100);
            View.AddSubview(customView);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

			var arr = NSBundle.MainBundle.LoadNib("MyView", null, null);
			var view = Runtime.GetNSObject<MyView>(arr.ValueAt(0));
            view.Frame = View.Frame;
			View.AddSubview(view);

		}
    }



    public class CustomView : UIView
    {
        public CustomView()
        {
            BackgroundColor = UIColor.Green;

            var square = new UIView();
            // Créer un carré 30 pixel sur 30 pixel en X = 0  et Y + 0
            square.BackgroundColor = UIColor.Red;
            square.Frame = new CoreGraphics.CGRect(0, 0, 30, 30);

            // Créer un label positionné en dessous du carré
            var label = new UILabel();
            label.Text = "Text";
            label.Frame = new CoreGraphics.CGRect(0, 35, 40, 20);

            // Ajout des vues enfants
            this.AddSubviews(square, label);
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
        }
    }
}
