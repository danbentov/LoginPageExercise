using LoginPageExercise.ViewModels;

namespace LoginPageExercise.Views;

public partial class LoginPageView : ContentPage
{
	public LoginPageView()
	{
		InitializeComponent();
		this.BindingContext = new LoginPageViewModel();
    }
}