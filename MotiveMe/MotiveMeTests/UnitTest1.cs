using Microsoft.VisualStudio.TestTools.UnitTesting;
using MotiveMe;
using MotiveMe.DAO;
using MotiveMe.Model;
using System;

namespace MotiveMeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ActivityDaoInsertWorking()
        {
            var activity = new ActivityDAO();
            var activity1 = new Activity
            {
                Date = new DateTime(2019, 01, 20),
                ActivityVal = "Work",
                Reward = "Candy"
            };
            activity.InsertActivity(activity1);
            Assert.Equals(activity, activity1);
        }

        [TestMethod]
        public void ActivityDaoDeleteWorking()
        {
            var activity = new ActivityDAO();
            var activity1 = new Activity
            {
                Date = new DateTime(2019, 01, 20),
                ActivityVal = "Work",
                Reward = "Candy"
            };
            activity.DeleteActivity(activity1);
            ReferenceEquals(1, activity.GetAll().Count);
        }

        [TestMethod]
        public void NotesDaoIdWorking()
        {
            var note = new NoteDAO();
            var note1 = new Note
            {
                Topic = "Title",
                Value = "Filler"
            };
            note.InsertNote(note1);
            Assert.Equals(0, note.GetById(0));
        }

        [TestMethod]
        public void NotesDaoInsertWorking()
        {
            var note = new NoteDAO();
            var note1 = new Note
            {
                Topic = "Title",
                Value = "Filler"
            };
            note.InsertNote(note1);
            Assert.Equals(note, note1);
        }

        [TestMethod]
        public void NotesDaoDeleteWorking()
        {
            var note = new NoteDAO();
            var note1 = new Note
            {
                Topic = "Title",
                Value = "Filler"
            };
            note.InsertNote(note1);
            note.DeleteNote(0);
            Assert.Equals(note, note1);
        }
    }
}
