using System;
using Android.App;
using Android.Runtime;

namespace FormsDemo.Droid
{
	[Application]
	public class MainApplication : Application
	{
		public MainApplication ()
		{
		}

		public MainApplication (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		public override void OnCreate ()
		{
			base.OnCreate ();

			ApplauseSDK.Applause.StartNewSession (this, APPLAUSE_APP_KEY);
		}
	}
}