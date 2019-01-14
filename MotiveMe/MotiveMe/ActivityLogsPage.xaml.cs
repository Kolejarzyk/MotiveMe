using MotiveMe.Model;
using Xamarin.Forms;

namespace MotiveMe
{

    public partial class ActivityLogsPage : ContentPage
    {
        public ActivityLogsPage()
        {
            InitializeComponent();

            Activity.ItemsSource = AppDatabase.activityDao.GetAll();
            Activity.ItemTapped += Activity_ItemTapped;


        }

        private async void Activity_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var content = e.Item as Activity;
       
            await Navigation.PushAsync(new ActivityDetailPage(content));
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await this.Navigation.PushAsync(new AddActivity());
        }
    }
}

      
