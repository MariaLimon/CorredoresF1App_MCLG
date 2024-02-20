using CorredoresF1App_MCLG.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorredoresF1App_MCLG
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new CorredorPage();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
