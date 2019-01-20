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
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ActivityDetailPage : ContentPage
	{
        public Activity CurrentActivity { get; private set; }
        public ActivityDetailPage()
        {

        }
		public ActivityDetailPage(Activity content)
		{
			InitializeComponent ();
            CurrentActivity = content;
            Goal.Text = content.ActivityVal;
            Date.Text = content.Date.ToString();
            Reward.Text = content.Reward;


        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            AppDatabase.activityDao.DeleteActivity(CurrentActivity);
            Navigation.PushAsync(new ActivityLogsPage());
        }

        
    }
}