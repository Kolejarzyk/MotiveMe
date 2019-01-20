using MotiveMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MotiveMe
{
	/*
		Main class responsible for AddActivity functionality
	*/
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddActivity : ContentPage
	{
		// Starts function
		public AddActivity ()
		{
			InitializeComponent ();
		}
		
		// Button adding set activity to the database
        private void Button_Clicked(object sender, System.EventArgs e)
        {
            var activity = new Activity
            {
                Date = new DateTime(Date.Date.Year, Date.Date.Month, Date.Date.Day),
                ActivityVal = Goal.Text,
                Reward = Reward.Text
            };
            AppDatabase.activityDao.InsertActivity(activity);

            Navigation.PushAsync(new ActivityLogsPage());
        }
    }
}