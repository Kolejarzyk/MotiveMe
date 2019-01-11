using MotiveMe.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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

        public void DeleteActivity(int id)
        {
            ActivityDao.RemoveAt(id);
        }


        public Activity GetById(int id)
        {
            return ActivityDao[id];
        }

        public ObservableCollection<Activity> GetAll()
        {
            return ActivityDao;
        }
    }
}
