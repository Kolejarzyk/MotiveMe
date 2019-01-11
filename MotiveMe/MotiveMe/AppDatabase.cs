using MotiveMe.DAO;
using System;

namespace MotiveMe
{
    public static class AppDatabase
    {
        public static String Name { get; set; }
        public static NoteDAO noteDao = new NoteDAO();
        public static ActivityDAO activityDao = new ActivityDAO();
        
    }
}
