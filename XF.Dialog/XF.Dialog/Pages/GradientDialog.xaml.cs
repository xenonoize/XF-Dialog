﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Dialog.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GradientDialog : ContentPage
	{
		public GradientDialog()
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