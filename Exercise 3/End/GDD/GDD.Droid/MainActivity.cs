using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using GDD.Core.ViewModels;

namespace GDD.Droid
{
    [Activity(Label = "GDD.Droid", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : MvxAppCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}