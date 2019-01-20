using System;
using Xamarin.Forms;

namespace MotiveMe
{
	/*
		Class responsible for creating notes
	*/
	public partial class CreateNotePage : ContentPage
	{
		public CreateNotePage ()
		{
			InitializeComponent ();
		}

		// Sets title and description of a note and adds it to the database.
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