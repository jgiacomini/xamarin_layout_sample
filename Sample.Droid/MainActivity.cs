using Android.App;
using Android.OS;
using Android.Widget;
using static Android.Views.ViewGroup;

namespace Sample.Droid
{
    [Activity(Label = "Sample.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Via AXML
            SetContentView(Resource.Layout.Main);

            // Via code
            TextView textView = new TextView(this);
            string textToDisplay = "Ajouté par code !";
            textView.SetText(textToDisplay.ToCharArray(), 0, textToDisplay.Length);
            textView.LayoutParameters.Height = LayoutParams.WrapContent;
            textView.LayoutParameters.Width = LayoutParams.MatchParent;
            this.SetContentView(textView);
        }
    }
}

