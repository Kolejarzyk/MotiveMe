using Plugin.LocalNotifications;
using System;
using Xamarin.Forms;    

namespace MotiveMe {
    
	/*
		Class responsible for Alarms functionality
	*/
    public partial class Alarms : ContentPage {    
        public Alarms() {    
            InitializeComponent();            
        }

		// Sets date of alarm notification
        private void Button_Clicked(object sender, System.EventArgs e)
        {
            CrossLocalNotifications.Current.Show(Title.Text.ToString(), 
                Body.Text.ToString(), 
                101, 
                new DateTime(DatePicker.Date.Year, DatePicker.Date.Month, DatePicker.Date.Day,TimePicker.Time.Hours, TimePicker.Time.Minutes, 0));
        }
    }    
} 