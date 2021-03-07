using iOSStatusBarXF.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Page), typeof(StatusBarRendrerer))]
namespace iOSStatusBarXF.iOS
{ 
    public class StatusBarRendrerer : PageRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            SetStatusBarStyle(StatusBar.GetStatusBarStyle(Element));
        }

        private void SetStatusBarStyle(StatusBarStyle statusBarStyle)
        {
            switch (statusBarStyle)
            {
                case StatusBarStyle.Dark:
                    UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.DarkContent, true);
                    UIApplication.SharedApplication.SetStatusBarHidden(false, true);
                    break;
                case StatusBarStyle.White:
                    UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, true);
                    UIApplication.SharedApplication.SetStatusBarHidden(false, true);
                    break;
                case StatusBarStyle.Hidden:
                    UIApplication.SharedApplication.SetStatusBarHidden(true, true);
                    break;
                case StatusBarStyle.Default:
                default:
                    UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.Default, true);
                    UIApplication.SharedApplication.SetStatusBarHidden(false, true);
                    break;
            }

            SetNeedsStatusBarAppearanceUpdate();
        }
    }
}
