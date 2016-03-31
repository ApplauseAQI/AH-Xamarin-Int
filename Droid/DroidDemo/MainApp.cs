using System;
using Android.App;
using Android.Runtime;

namespace DroidDemo
{
	[Application]
	public class MainApp : Application
	{
		public MainApp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public override void OnCreate ()
		{
			base.OnCreate ();

			ApplauseSDK.Configuration configuration = new ApplauseSDK.Configuration.Builder (this)
				.WithAPIKey (APPLAUSE_APP_KEY)
				.Build ();

			ApplauseSDK.Applause.StartNewSession (this, configuration);
		}
	}
}