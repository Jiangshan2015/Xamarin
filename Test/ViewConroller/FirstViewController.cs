
using System;

using UIKit;

namespace Test
{
	public partial class FirstViewController : UIViewController
	{
		public FirstViewController() : base("FirstViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

