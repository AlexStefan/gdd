using Android.OS;
using GDD.Core.Helpers;

namespace GDD.Droid.Helpers
{
    public class AppInfo : IAppInfo
    {
        public string GetModelName()
        {
            return Build.Model;
        }
    }
}