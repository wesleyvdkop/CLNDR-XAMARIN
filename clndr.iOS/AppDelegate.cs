﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using SVG.Forms.Plugin.iOS;
using Syncfusion.ListView.XForms.iOS;
using Syncfusion.SfCalendar.XForms.iOS;
using Syncfusion.SfPicker.XForms.iOS;
using Syncfusion.XForms.iOS.Buttons;
using Syncfusion.XForms.iOS.DataForm;
using Syncfusion.XForms.iOS.TextInputLayout;
using UIKit;

namespace clndr.iOS
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
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Xamarin.Calabash.Start();
            global::Xamarin.Forms.Forms.Init();
            SvgImageRenderer.Init();
            LoadApplication(new App());

            SfButtonRenderer.Init();
            Syncfusion.XForms.iOS.Border.SfBorderRenderer.Init();
            Syncfusion.XForms.iOS.TabView.SfTabViewRenderer.Init();
            SfCalendarRenderer.Init();
            SfListViewRenderer.Init();
            SfDataFormRenderer.Init();
            SfPickerRenderer.Init();
            SfTextInputLayoutRenderer.Init();
            return base.FinishedLaunching(app, options);
        }
    }
}
