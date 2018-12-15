using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MotiveMe
{

	public partial class WelcomePage : ContentPage
	{
		public WelcomePage ()
		{
			InitializeComponent ();

            DatePicker datePicker = new DatePicker
            {
                Date = new DateTime().ToUniversalTime()
            };
        }

        private void Button_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}