using MotiveMe.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotiveMe
{
    public static class AppDatabase
    {
        public static NoteDAO noteDao = new NoteDAO();
    }
}
