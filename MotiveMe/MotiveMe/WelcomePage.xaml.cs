using MotiveMe.Model;
using System;
using Xamarin.Forms;

namespace MotiveMe
{

	public partial class WelcomePage : ContentPage
	{
        public string Name { get; set; }
        public WelcomePage ()
		{
            
        InitializeComponent ();

            Name = AppDatabase.Name;
            BindingContext = this;
            var activity = new Activity
            {
                Date = new DateTime(2019, 09, 22),
                ActivityVal = "Trzeba zrobić xamarina",
                Reward = "Zdany przedmiot"
            };
            var activity1 = new Activity
            {
                Date = new DateTime(2019, 09, 03),
                ActivityVal = "Trzeba przebiec maraton",
                Reward = "Zdany przedmiot"
            };
            var activity2 = new Activity
            {
                Date = new DateTime(2019, 04, 21),
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
                Date = new DateTime(2019, 09, 22),
                ActivityVal = "Trzeba zrobić statystyke moich odechów",
                Reward = "Zdany przedmiot"
            };

            AppDatabase.activityDao.InsertActivity(activity);
            AppDatabase.activityDao.InsertActivity(activity1);
            AppDatabase.activityDao.InsertActivity(activity2);
            AppDatabase.activityDao.InsertActivity(activity3);
            AppDatabase.activityDao.InsertActivity(activity4);

            Activity.ItemsSource = AppDatabase.activityDao.GetAll();


        }

        private void Button_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}