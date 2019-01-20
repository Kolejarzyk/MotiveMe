using MotiveMe.Model;
using System;
using Xamarin.Forms;

namespace MotiveMe
{
	/*
		Main Page of MotiveMe
	*/
    public partial class MainPage : ContentPage
    {
		// Sets navigation and fills database on start
        public MainPage()
        {
            InitializeComponent();
            PopulateDatabase();
            NavigationPage.SetHasNavigationBar(this, false);
        }

		// On button click, adds a specified name to database.		
        private async void Button_Clicked(object sender, EventArgs e)
        {
            AppDatabase.Name = Name.Text;
            await this.Navigation.PushAsync(new MSPage());
        }

		// Fills Database with set activities
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
                Reward = "Słodkości"
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
                ActivityVal = "Trzeba zrobić statystyke",
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
