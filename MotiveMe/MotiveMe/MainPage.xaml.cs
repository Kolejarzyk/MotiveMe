using MotiveMe.Model;
using System;
using Xamarin.Forms;

namespace MotiveMe
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            PopulateDatabase();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            AppDatabase.Name = Name.Text;
            await this.Navigation.PushAsync(new MSPage());
        }

        private void PopulateDatabase()
        {
            var activity = new Activity
            {
                Date = new DateTime(2019, 01, 20),
                ActivityVal = "Trzeba zrobić xamarina",
                Reward = "Zdany przedmiot"
            };
            var activity1 = new Activity
            {
                Date = new DateTime(2019, 01, 20),
                ActivityVal = "Trzeba przebiec maraton",
                Reward = "Zdany przedmiot"
            };
            var activity2 = new Activity
            {
                Date = new DateTime(2019, 01, 21),
                ActivityVal = "Trzeba upiec ciastka",
                Reward = "Zdany przedmiot"
            };
            var activity3 = new Activity
            {
                Date = new DateTime(2019, 01, 22),
                ActivityVal = "Trzeba zrobić androida",
                Reward = "Zdany przedmiot"
            };
            var activity4 = new Activity
            {
                Date = new DateTime(2019, 01, 20),
                ActivityVal = "Trzeba zrobić statystyke moich odechów",
                Reward = "Zdany przedmiot"
            };

            AppDatabase.activityDao.InsertActivity(activity);
            AppDatabase.activityDao.InsertActivity(activity1);
            AppDatabase.activityDao.InsertActivity(activity2);
            AppDatabase.activityDao.InsertActivity(activity3);
            AppDatabase.activityDao.InsertActivity(activity4);
        }
    }
}
