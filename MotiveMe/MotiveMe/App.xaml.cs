using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MotiveMe
{
	/*
		The main MotiveMe class
		Starts with navigation
	*/
    public partial class App : Application
    {
		// Starts navigation function
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

		// Handled when your app starts
        protected override void OnStart()
        {
            
        }

		// Handled when your app sleeps
        protected override void OnSleep()
        {
            
        }

		// Handled when your app resumes
        protected override void OnResume()
        {
           
        }
    }
}
