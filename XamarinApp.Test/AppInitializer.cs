using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamarinApp.Test
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{
				return ConfigureApp
					.Android
					//.InstalledApp("com.companyname.xamarinapp") only work on release ? or is mono runtime
					.ApkFile(@"./XamarinApp/XamarinApp.Android/bin/Debug/com.companyname.xamarinapp.apk")
					.StartApp(Xamarin.UITest.Configuration.AppDataMode.DoNotClear);
			}

			return ConfigureApp.iOS.StartApp();
		}
	}
}