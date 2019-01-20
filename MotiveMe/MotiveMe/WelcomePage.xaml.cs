using MotiveMe.Model;
using System;
using Xamarin.Forms;

namespace MotiveMe
{
	/*
		Applications Welcoming page
	*/
	public partial class WelcomePage : ContentPage
	{
		// Sets name of the user
        public string Name { get; set; }
        public WelcomePage ()
		{
            
        InitializeComponent ();

            var currentDate = DateTime.Today;
            Name = AppDatabase.Name;
            BindingContext = this;
           

            Activity.ItemsSource = AppDatabase.activityDao.GetByDate(currentDate);
        }
    }
}