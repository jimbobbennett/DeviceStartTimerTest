using System;

using Xamarin.Forms;
using System.Diagnostics;

namespace DispatcherTimerTest
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new ContentPage 
			{
				Content = new StackLayout 
				{
					VerticalOptions = LayoutOptions.Center,
					Children = 
					{
						new Label 
						{
							XAlign = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						}
					}
				}
			};

			Device.StartTimer(TimeSpan.FromSeconds(5), () =>
				{
					Debug.WriteLine("Timer tick");
					return true;
				});
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			Debug.WriteLine("OnSleep");
		}

		protected override void OnResume ()
		{
			Debug.WriteLine("OnResume");
		}
	}
}

