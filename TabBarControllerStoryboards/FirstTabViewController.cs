using Foundation;
using System;
using UIKit;

namespace TabBarControllerStoryboards
{
    public partial class FirstTabViewController : UIViewController
    {
		protected FirstTabViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

 		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			var storyboard = UIStoryboard.FromName("First", null);
			var navigationController = storyboard.InstantiateInitialViewController();;
			AddChildViewController(navigationController);
			View.AddSubview(navigationController.View);
			navigationController.DidMoveToParentViewController(this);
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
    }
}