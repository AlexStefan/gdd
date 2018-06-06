using GDD.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;

namespace GDD.Touch
{
	public partial class SecondViewController : MvxViewController<SecondViewModel>
    {
        public SecondViewController() : base("SecondViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
         
			var set = this.CreateBindingSet<SecondViewController, SecondViewModel>();
			set.Bind(lbModel).To(vm => vm.ModelName);
            set.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}