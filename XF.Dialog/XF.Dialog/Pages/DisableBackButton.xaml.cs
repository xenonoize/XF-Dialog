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
	public partial class DisableBackButton : ContentPage
	{
		public DisableBackButton()
		{
			InitializeComponent();
			CloseBtn.Clicked += CloseBtn_Clicked;
		}

		private void CloseBtn_Clicked(object sender, EventArgs e)
		{
			// Closes this modal.
			Navigation.PopModalAsync();
		}

		protected override bool OnBackButtonPressed()
		{
			return true;
		}
	}
}