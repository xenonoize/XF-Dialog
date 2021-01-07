using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Dialog
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BasicDialogSample : ContentPage
	{
		public BasicDialogSample()
		{
			InitializeComponent();
			CloseBtn.Clicked += CloseBtn_Clicked;
		}

		private void CloseBtn_Clicked(object sender, EventArgs e)
		{
			// Closes this modal.
			Navigation.PopModalAsync();
		}
	}
}