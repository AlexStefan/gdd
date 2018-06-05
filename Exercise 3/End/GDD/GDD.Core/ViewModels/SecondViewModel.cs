using MvvmCross.ViewModels;

namespace GDD.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        private string modelName;
        public string ModelName
        {
            get
            {
                return modelName;
            }
            set
            {
                modelName = value;
                RaisePropertyChanged(nameof(ModelName));
            }
        }

        public SecondViewModel()
        {
            ModelName = "Nothing";
        }
    }
}