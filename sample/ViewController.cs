﻿using System;
using AIDatePickerController;
using UIKit;

namespace sample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}
		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);



		}
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			var picker = new AIDatePickerController.AIDatePickerController(DateTime.Now,
												  (p) =>
												  {

												  },
											 	(p) =>
												 {
													 this.DismissViewController(false,null);
												 });


			btn.TouchUpInside += (sender, e) =>
			{
				this.PresentViewController(picker, true, null);
			};

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

