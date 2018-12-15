using System;
using Xamarin.Forms;

namespace MotiveMe
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new MSPage());
        }
    }
}
