using Android.App;
using Android.OS;
using GDD.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace GDD.Droid
{
    [Activity(Label = "Second")]
    public class SecondActivity : MvxAppCompatActivity<SecondViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Second);
        }
    }
}