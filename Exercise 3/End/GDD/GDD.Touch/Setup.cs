using GDD.Core;
using GDD.Core.Helpers;
using GDD.Touch.Helpers;
using MvvmCross;
using MvvmCross.Platforms.Ios.Core;

namespace GDD.Touch
{
	public class Setup : MvxIosSetup<App>
    {
		protected override void InitializeFirstChance()
        {
            Mvx.LazyConstructAndRegisterSingleton<IAppInfo, AppInfo>();
        }
    }
}