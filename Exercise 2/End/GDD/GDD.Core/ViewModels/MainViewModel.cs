using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace GDD.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private int count = 0;

        public IMvxCommand ChangeValueCommand => new MvxCommand(() => { ButtonText = $"{count++} clicks!"; });

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

        public MainViewModel()
        {
            ButtonText = "Hello World, Click Me!";
        }
    }
}