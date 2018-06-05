using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace GDD.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private IMvxNavigationService navigationService;
        private int count = 0;

        public IMvxCommand ChangeValueCommand => new MvxCommand(() => { ButtonText = $"{count++} clicks!"; });
        public IMvxCommand NavigateFurtherCommand => new MvxCommand(() => { navigationService.Navigate<SecondViewModel>(); });

        private string buttonText;
        public string ButtonText
        {
            get
            {
                return buttonText;
            }
            set
            {
                buttonText = value;
                RaisePropertyChanged(nameof(ButtonText));
            }
        }

        public MainViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
            ButtonText = "Hello World, Click Me!";
        }
    }
}