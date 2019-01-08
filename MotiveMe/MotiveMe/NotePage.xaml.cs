
using MotiveMe.DAO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MotiveMe
{
	
	public partial class NotePage : ContentPage
	{
        
        public NotePage ()
		{
			InitializeComponent ();

            var note = new Note
            {
                Topic = "Zmiana flagi",
                Value = "Nie mogę zapomnieć żeby zmienić flagi oraz sztandary na apel który odbędzie się w Strzebielinie"
            };
            var note1 = new Note
            {
                Topic = "Zmiana flagi",
                Value = "Nie mogę zapomnieć żeby zmienić flagi oraz sztandary na apel który odbędzie się w Krakowie"
            };
            AppDatabase.noteDao.InsertNote(note);
            AppDatabase.noteDao.InsertNote(note1);
            foreach (Note item in AppDatabase.noteDao.GetAll())
            {
                NotePageLayout.Children.Add(new Label { Text = item.Topic, TextDecorations = TextDecorations.Underline });
                NotePageLayout.Children.Add(new Label { Text = item.Value });
            }
            
             
        }

        private void CreateNote_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CreateNotePage());
        }
    }
}