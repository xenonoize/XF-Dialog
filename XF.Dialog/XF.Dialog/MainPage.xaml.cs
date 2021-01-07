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
		}

		private void AnimatedDialogSampleBtn_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new AnimatedDialog(), false);
		}

		private void DialogSampleBtn_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new BasicDialogSample());
		}
	}
}