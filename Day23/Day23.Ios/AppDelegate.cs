﻿using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.Platform;
using Foundation;
using UIKit;

namespace Day23.Ios
{
	[Register("AppDelegate")]
	public class AppDelegate : MvxApplicationDelegate
	{
		public override UIWindow Window { get; set; }

		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
		{
			Window = new UIWindow(UIScreen.MainScreen.Bounds);

			var setup = new Setup(this, Window);
			setup.Initialize();

			var startup = Mvx.Resolve<IMvxAppStart>();
			startup.Start();

			Window.MakeKeyAndVisible();

			return true;
		}
	}
}
