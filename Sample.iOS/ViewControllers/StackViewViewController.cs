using System;
using UIKit;

namespace Sample.iOS
{
    public class StackViewViewController : UIViewController
    {
        public StackViewViewController()
        {
			Title = "Exemple de vue personalisée";
			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            UIStackView stackView = new UIStackView();

            stackView.Alignment = UIStackViewAlignment.Center;
            stackView.Axis = UILayoutConstraintAxis.Horizontal;

            stackView.Distribution = UIStackViewDistribution.FillProportionally;
            //stackView.Frame = View.Frame;
            View.AddSubviews(stackView);

            UILabel view1 = new UILabel();
            view1.BackgroundColor = UIColor.Red;
            view1.Text = "Vue 1";
            view1.SizeToFit();

			UILabel view2 = new UILabel();
            view2.BackgroundColor = UIColor.Blue;
			view2.Text = "Vue 2";
			view2.SizeToFit();

			UILabel view3 = new UILabel();
            view3.BackgroundColor = UIColor.Green;
			view3.Text = "Vue 3";
            view3.SizeToFit();


			stackView.AddArrangedSubview(view1);
			stackView.AddArrangedSubview(view2);
			stackView.AddArrangedSubview(view3);

            stackView.InvalidateIntrinsicContentSize();
		}
    }
}
