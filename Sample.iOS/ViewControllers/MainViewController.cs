using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Sample.iOS
{
	public partial class MainViewController : UIViewController
	{


		public MainViewController()
		{
			Title = "Exemple liste simple";
			View.BackgroundColor = UIColor.White;
			EdgesForExtendedLayout = UIRectEdge.None;
		}


		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var customViewButton = UIButton.FromType(UIButtonType.System);
			customViewButton.SetTitle("Vue personalisée", UIControlState.Normal);
			customViewButton.TouchUpInside += CustomView_TouchUpInside;
			customViewButton.Frame = new CGRect(10, 10, View.Bounds.Width - 20, 40);

			var simpleLayoutButton = UIButton.FromType(UIButtonType.System);
			simpleLayoutButton.SetTitle("Mise en page classique", UIControlState.Normal);
			simpleLayoutButton.TouchUpInside += SimpleLayout_TouchUpInside;
			simpleLayoutButton.Frame = new CGRect(10, 60, View.Bounds.Width - 20, 40);

			var stackViewButton = UIButton.FromType(UIButtonType.System);
			stackViewButton.SetTitle("UIStackView", UIControlState.Normal);
			stackViewButton.TouchUpInside += StackView_TouchUpInside;
			stackViewButton.Frame = new CGRect(10, 110, View.Bounds.Width - 20, 40);

			var constrainButton = UIButton.FromType(UIButtonType.System);
			constrainButton.SetTitle("Les contraintes", UIControlState.Normal);
			constrainButton.TouchUpInside += Constraint_TouchUpInside;
			constrainButton.Frame = new CGRect(10, 160, View.Bounds.Width - 20, 40);

            View.AddSubviews(customViewButton, simpleLayoutButton, stackViewButton, constrainButton);
		}


		void CustomView_TouchUpInside(object sender, EventArgs e)
		{
			this.NavigationController.PushViewController(new CustomViewViewController(), true);
		}

		void SimpleLayout_TouchUpInside(object sender, EventArgs e)
		{
			this.NavigationController.PushViewController(new ClassicLayoutViewController(), true);
		}


		void StackView_TouchUpInside(object sender, EventArgs e)
		{
            this.NavigationController.PushViewController(new StackViewViewController(), true);
		}

		void Constraint_TouchUpInside(object sender, EventArgs e)
		{
			this.NavigationController.PushViewController(new ConstraintViewController(), true);
		}
	}

}
