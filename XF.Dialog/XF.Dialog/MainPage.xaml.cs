using Xamarin.Forms;

namespace XF.Dialog
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			BasicDialogSampleBtn.Clicked += DialogSampleBtn_Clicked;
			AnimatedDialogSampleBtn.Clicked += AnimatedDialogSampleBtn_Clicked;
			TapToCloseDialogSampleBtn.Clicked += TapToCloseDialogSampleBtn_Clicked;
		}

		private void TapToCloseDialogSampleBtn_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new TapToCloseDialog());
		}

		private void AnimatedDialogSampleBtn_Clicked(object sender, System.EventArgs e)
		{
			// Open a modal passing animated:false to disable the platform animation
			Navigation.PushModalAsync(new AnimatedDialog(), animated: false);
		}

		private void DialogSampleBtn_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new BasicDialogSample());
		}
	}
}