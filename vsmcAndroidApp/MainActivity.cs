using Android.App;
using Android.Widget;
using Android.OS;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace vsmcAndroidApp
{
    [Activity(Label = "vsmcAndroidApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            MobileCenter.Start("547b7c36-e0a6-42bf-8c16-aab779ff9a21",
                       typeof(Analytics), typeof(Crashes));
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

