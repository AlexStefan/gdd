using GDD.Core.Helpers;
using UIKit;

namespace GDD.Touch.Helpers
{
	public class AppInfo : IAppInfo
    {      
		public string GetModelName()
		{
			return UIDevice.CurrentDevice.Name;
		}
	}
}