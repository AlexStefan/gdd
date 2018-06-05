using GDD.Core.ViewModels;
using MvvmCross.ViewModels;

namespace GDD.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainViewModel>();
        }
    }
}