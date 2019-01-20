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

            var currentDate = DateTime.Today;
            Name = AppDatabase.Name;
            BindingContext = this;
           

            Activity.ItemsSource = AppDatabase.activityDao.GetByDate(currentDate);


        }

    }
}