using MotiveMe.Model;
using Xamarin.Forms;

namespace MotiveMe
{
	/*
		Main Logs page class
	*/
    public partial class ActivityLogsPage : ContentPage
    {
		// Adds navigations function to queue to execute
        public ActivityLogsPage()
        {
            InitializeComponent();

            Activity.ItemsSource = AppDatabase.activityDao.GetAll();
            Activity.ItemTapped += Activity_ItemTapped;
        }

		// A new page navigation function
        private async void Activity_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var content = e.Item as Activity;
       
            await Navigation.PushAsync(new ActivityDetailPage(content));
        }

		// Starts a navigation function 
        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await this.Navigation.PushAsync(new AddActivity());
        }
    }
}

      
