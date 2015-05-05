using Foundation;
using System;
using System.CodeDom.Compiler;
using System.Drawing;
using UIKit;

namespace Layout
{
    partial class LoginViewController : UIViewController
    {
        public LoginViewController(IntPtr handle)
            : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            ////base.ViewDidLoad();
            ////this.NavigationController.NavigationBar.BackgroundColor = UIColor.Black;
            UIImageView oUIImageView = new UIImageView(new RectangleF(0, 0, 150, 30));
            oUIImageView.Image = new UIImage("top_banner.jpg");
            //this.NavigationItem.TitleView = oUIImageView;
            ////this.NavigationController.NavigationBar.TitleTextAttributes.ForegroundColor = UIColor.White;
            ////NavigationController.
            //this.Title = "test";
            //this.NavigationController.NavigationBar.TitleTextAttributes = new UIStringAttributes() { ForegroundColor = UIColor.White, };
            //NavigationController.Title = "Test";


            //this.NavigationController.NavigationBar.BarTintColor = UIColor.FromPatternImage(UIImage.FromFile("top_banner.jpg"));
            this.NavigationController.NavigationBar.BackItem.TitleView = oUIImageView;
        }
    }
}
