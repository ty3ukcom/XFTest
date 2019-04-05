using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using XFTest.iOS.Core;

namespace XFTest.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            Xamarin.Forms.Forms.Init();
            XF.Material.iOS.Material.Init();

            var appContainer = new PlatformContainer();
            appContainer.Setup();

            this.LoadApplication(CommonServiceLocator.ServiceLocator.Current.GetInstance<App>());

            return base.FinishedLaunching(uiApplication, launchOptions);
        }
    }
}
