using GDD.Core.Helpers;
using MvvmCross;
using MvvmCross.ViewModels;

namespace GDD.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        public string ModelName
        {
            get
            {
                return Mvx.Resolve<IAppInfo>().GetModelName();
            }
        }
    }
}