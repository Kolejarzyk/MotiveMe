using System;
using Xamarin.Forms;

namespace MotiveMe
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            AppDatabase.Name = Name.Text;
            await this.Navigation.PushAsync(new MSPage());
        }
    }
}
