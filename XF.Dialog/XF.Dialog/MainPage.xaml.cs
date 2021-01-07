using Xamarin.Forms;

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
		}

		private void GradientBackgroundDialogSampleBtn_Clicked(object sender, System.EventArgs e)
		{
			// Opens a modal with default animation.
			Navigation.PushModalAsync(new GradientDialog());
		}

		private void AnimatedDialogSampleBtn_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new AnimatedDialog(), false);
		}

		private void BasicDialogSampleBtn_Clicked(object sender, System.EventArgs e)
		{
			// Opens a modal with default animation.
			Navigation.PushModalAsync(new BasicDialogSample());
		}
	}
}