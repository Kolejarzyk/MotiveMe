using MotiveMe.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MotiveMe.DAO
{
   public class ActivityDAO
    {
        public ObservableCollection<Activity> ActivityDao;

        public ActivityDAO()
        {
            ActivityDao = new ObservableCollection<Activity>();
        }


        public void InsertActivity(Activity note)
        {
            ActivityDao.Add(note);
        }

        public void DeleteActivity(Activity activity)
        {
            ActivityDao.Remove(activity);
        }


        public Activity GetById(int id)
        {
            return ActivityDao[id];
        }

        public ObservableCollection<Activity> GetAll()
        {
            return ActivityDao;
        }

        public IEnumerable<Activity> GetByDate(DateTime date)
        {
            return ActivityDao.Where(x => x.Date.Date.Day == date.Date.Day);
        }
    }
}
