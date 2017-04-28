using System;

using UIKit;

namespace Test
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			Acount.BorderStyle = UITextBorderStyle.RoundedRect;
			Acount.Frame = new CoreGraphics.CGRect(50, 200, UIScreen.MainScreen.Bounds.Size.Width - 100, 50);

			password.BorderStyle = UITextBorderStyle.RoundedRect;
			password.Frame = new CoreGraphics.CGRect(50, 265, UIScreen.MainScreen.Bounds.Size.Width - 100, 50);

			LoginBtn.Frame = new CoreGraphics.CGRect(100,350,UIScreen.MainScreen.Bounds.Size.Width-200,40);
			LoginBtn.BackgroundColor = UIColor.Cyan;
			LoginBtn.ClipsToBounds = true;
			LoginBtn.Layer.CornerRadius = 4;
		}

		partial void UIButton18_TouchUpInside(UIButton sender)
		{
			if (Acount.Text == "111" && password.Text == "111")
			{
				MyViewController myVC = new MyViewController();
				FirstViewController fVC = new FirstViewController();

				UITabBarController tabBarVC = new UITabBarController();
				tabBarVC.ViewControllers = new UIViewController[] {
					myVC,
					fVC
				};

				tabBarVC.TabBar.Items[0].Title = "首页";
				tabBarVC.TabBar.Items[1].Title = "第一页";


				UINavigationController nvc = new UINavigationController(tabBarVC);


				this.PresentViewController(nvc, true, null);

			}
			else
			{
				UIAlertView alert = new UIAlertView();
                alert.Title = "提示";
				alert.Message = "账号密码错误";
				alert.AddButton("确定");
				alert.Show();
			}
			//throw new NotImplementedException();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
