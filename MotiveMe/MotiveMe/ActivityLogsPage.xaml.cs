using Xamarin.Forms;

namespace MotiveMe
{

    public partial class ActivityLogsPage : ContentPage
    {
        public ActivityLogsPage()
        {
            InitializeComponent();

            Activity.ItemsSource = AppDatabase.activityDao.GetAll();
            



        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await this.Navigation.PushAsync(new AddActivity());
        }
    }

      
}