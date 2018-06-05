using GDD.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;

namespace GDD.Touch
{
	public partial class MainViewController : MvxViewController<MainViewModel>
    {
        public MainViewController() : base("MainViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

			var set = this.CreateBindingSet<MainViewController, MainViewModel>();
            set.Bind(myButton).To(vm => vm.ChangeValueCommand);
            set.Bind(myButton).For("Title").To(vm => vm.ButtonText);
            set.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}