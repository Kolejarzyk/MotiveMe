using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MotiveMe
{

	public partial class CreateNotePage : ContentPage
	{
		public CreateNotePage ()
		{
			InitializeComponent ();
		}

        private void AddNote_Clicked(object sender, EventArgs e)
        {
            var note = new Note()
            {
                Topic = NoteTitle.Text,
                Value = Description.Text
            };

            AppDatabase.noteDao.InsertNote(note);
            Navigation.PushAsync(new NotePage());
        }
    }
}