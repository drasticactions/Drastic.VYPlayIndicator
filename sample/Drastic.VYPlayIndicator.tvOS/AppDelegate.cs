namespace Drastic.VYPlayIndicator.tvOS;

[Register ("AppDelegate")]
public class AppDelegate : UIApplicationDelegate {
	public override UIWindow? Window {
		get;
		set;
	}

	public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
	{
        this.Window = new UIWindow();

        var dv = new Drastic.PlayIndicator.iOS.VYTableViewController();

        // dv.OnSelection += Dv_OnSelection;

        this.Window!.RootViewController = new UIKit.UINavigationController(dv);
        this.Window!.MakeKeyAndVisible();

        return true;
	}
}
