using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Dialog.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TapToCloseDialog : ContentPage
	{
		public TapToCloseDialog()
		{
			InitializeComponent();
		}

		private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}