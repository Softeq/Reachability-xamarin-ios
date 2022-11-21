using System.Diagnostics;
using ObjCRuntime;
using ReachabilityBindings;

namespace ReachabilitySamples;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    private Reachability? _reach;

    public override UIWindow? Window { get; set; }

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        // create a new window instance based on the screen size
        Window = new UIWindow(UIScreen.MainScreen.Bounds);

        // create a UIViewController with a single UILabel
        var vc = new UIViewController();
        vc.View!.AddSubview(new UILabel(Window!.Frame)
        {
            BackgroundColor = UIColor.SystemBackground,
            TextAlignment = UITextAlignment.Center,
            Text = "Hello, iOS!",
            AutoresizingMask = UIViewAutoresizing.All,
        });
        Window.RootViewController = vc;

        // make the window visible
        Window.MakeKeyAndVisible();



        // Allocate a reachability object
        _reach = Reachability.ReachabilityForInternetConnection;// ReachabilityWithHostName("www.google.com");


        //var handle = Messaging.IntPtr_objc_msgSend(classHandle, selector);
        //var a = Runtime.GetNSObject<Reachability>(classHandle);

        // Set the blocks
        _reach.ReachableBlock = (Reachability r) =>
            {
                // keep in mind this is called on a background thread
                // and if you are updating the UI it needs to happen
                // on the main thread, like this:

                BeginInvokeOnMainThread(() =>
                {
                    Debug.WriteLine("REACHABLE");
                    Debug.WriteLine(r.CurrentReachabilityString);
                });
            };


        _reach.UnreachableBlock = (Reachability r) =>
                {
                    Debug.WriteLine("UNREACHABLE");
                };

        _reach.StartNotifier();

        return true;
    }
}
