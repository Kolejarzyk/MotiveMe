using System;
using System.Collections.Generic;
using System.Text;

namespace MotiveMe.DAO
{
	/*
		Data Access Object for Activity
	*/
   public class NoteDAO
    {
        public List<Note> NoteDao;

        public NoteDAO()
        {
            NoteDao = new List<Note>();
        }


        public void InsertNote(Note note)
        {
            NoteDao.Add(note);
        }

        public void DeleteNote(int id)
        {
            NoteDao.RemoveAt(id);
        }


        public Note GetById(int id)
        {
           return NoteDao[id];
        }

        public List<Note> GetAll()
        {
            return NoteDao;
        }
    }
}
