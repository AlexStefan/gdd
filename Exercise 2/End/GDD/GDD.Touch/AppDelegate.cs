using Foundation;
using GDD.Core;
using MvvmCross.Platforms.Ios.Core;
using UIKit;

namespace GDD.Touch
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register("AppDelegate")]
	public class AppDelegate : MvxApplicationDelegate<Setup, App>
	{
		public override UIWindow Window
		{
			get;
			set;
		}
	}
}