﻿using System;

using UIKit;

namespace GDD.Touch
{
    public partial class ViewController : UIViewController
	{
        int count = 1;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

		partial void ButtonClick(UIButton sender)
		{
			sender.SetTitle($"{count++} clicks!", UIControlState.Normal); 
		}
    }
}