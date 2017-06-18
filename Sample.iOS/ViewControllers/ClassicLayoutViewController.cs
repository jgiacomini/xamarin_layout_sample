using System;
using UIKit;

namespace Sample.iOS
{
    public class ClassicLayoutViewController : UIViewController
    {
		UIView _vueGauche;
		UIView _vueDroite;

		public ClassicLayoutViewController()
        {
			Title = "Mise en page classique";
			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;

		}


		public override void ViewDidLoad()
		{
			_vueGauche = new UIView();
			_vueGauche.BackgroundColor = UIColor.Red;
			_vueDroite = new UIView();
			_vueDroite.BackgroundColor = UIColor.Green;

			// Ajout des vues à la vue principale
            this.View.AddSubviews(_vueGauche, _vueDroite);

		}

		public override void ViewWillLayoutSubviews()
		{
			base.ViewWillLayoutSubviews();

			var marge = 10;
            var largeur = (View.Frame.Width - 3 * marge) / 2;
            var hauteur = (View.Frame.Height / 2);

            _vueGauche.Frame = new CoreGraphics.CGRect(marge, 10, largeur, hauteur);

            _vueDroite.Frame = new CoreGraphics.CGRect(_vueGauche.Frame.Right + marge, 10, largeur, hauteur);
        }


    }
}
