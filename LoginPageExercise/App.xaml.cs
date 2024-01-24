using LoginPageExercise.Views;

namespace LoginPageExercise
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPageView();
        }
    }
}