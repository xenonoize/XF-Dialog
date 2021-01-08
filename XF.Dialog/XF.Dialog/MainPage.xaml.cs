using Xamarin.Forms;

using XF.Dialog.Pages;

namespace XF.Dialog
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			BasicDialogSampleBtn.Clicked += BasicDialogSampleBtn_Clicked;
			AnimatedDialogSampleBtn.Clicked += AnimatedDialogSampleBtn_Clicked;
			GradientBackgroundDialogSampleBtn.Clicked += GradientBackgroundDialogSampleBtn_Clicked;
			TapToCloseDialogSampleBtn.Clicked += TapToCloseDialogSampleBtn_Clicked;
			DisableBackButtonSample.Clicked += DisableBackButtonSample_Clicked;
		}

		private void TapToCloseDialogSampleBtn_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new TapToCloseDialog());
		}

		private void GradientBackgroundDialogSampleBtn_Clicked(object sender, System.EventArgs e)
		{
			// Opens a modal with default animation.
			Navigation.PushModalAsync(new GradientDialog());
		}

		private void AnimatedDialogSampleBtn_Clicked(object sender, System.EventArgs e)
		{
			// Open a modal passing animated:false to disable the platform animation
			Navigation.PushModalAsync(new AnimatedDialog(), animated: false);
		}

		private void BasicDialogSampleBtn_Clicked(object sender, System.EventArgs e)
		{
			// Opens a modal with default animation.
			Navigation.PushModalAsync(new BasicDialogSample());
		}

		private void DisableBackButtonSample_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new Pages.DisableBackButton());
		}
	}
}