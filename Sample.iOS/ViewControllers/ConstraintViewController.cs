using System;
using UIKit;

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
    }
}
