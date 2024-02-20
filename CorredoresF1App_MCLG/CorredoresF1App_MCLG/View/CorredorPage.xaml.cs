using CorredoresF1App_MCLG.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorredoresF1App_MCLG.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CorredorPage : ContentPage
	{
		public CorredorPage()
		{
			InitializeComponent();
			BindingContext = new VMcorredor(Navigation);
		}
	}
}