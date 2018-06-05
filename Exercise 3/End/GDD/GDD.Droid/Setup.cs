using GDD.Core;
using GDD.Core.Helpers;
using GDD.Droid.Helpers;
using MvvmCross;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace GDD.Droid
{
    public class Setup : MvxAppCompatSetup<App>
    {
        protected override void InitializeFirstChance()
        {
            Mvx.LazyConstructAndRegisterSingleton<IAppInfo, AppInfo>();
        }
    }
}