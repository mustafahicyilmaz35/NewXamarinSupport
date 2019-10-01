using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using UIKit;

namespace Sekreter.iOS
{
    [Register(nameof(AppDelegate))]
    public partial class AppDelegate : MvxFormsApplicationDelegate<Setup, Core.App, UI.App>
    {
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            return base.FinishedLaunching(uiApplication, launchOptions);
        }
    }
}
