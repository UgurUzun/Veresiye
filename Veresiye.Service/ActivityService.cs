using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Data;
using Veresiye.Model;

namespace Veresiye.Service
{
    public class ActivityService : IActivityService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IRepository<Activity> activityRepository;

        public ActivityService(IUnitOfWork unitOfWork, IRepository<Activity>activityRepository)
        {
            this.unitOfWork = unitOfWork;
            this.activityRepository = activityRepository;
        }

        public void Delete(int id)
        {
            var activity = activityRepository.Get(id);
            if(activity != null)
            {
                activityRepository.Delete(activity);
                unitOfWork.SaveChanges();
            }
        }

        public Activity Get(int id)
        {
            return activityRepository.Get(id);
        }

        public IEnumerable<Activity> GetAll()
        {
            return activityRepository.GetAll();
        }

        public void Insert(Activity activity)
        {
            activityRepository.Insert(activity);
            unitOfWork.SaveChanges();
        }

        public void Update(Activity activity)
        {
            activityRepository.Update(activity);
            unitOfWork.SaveChanges();
        }
    }

    public interface IActivityService
    {
        void Insert(Activity activity);
        void Update(Activity activity);
        void Delete(int id);
        IEnumerable<Activity> GetAll();
        Activity Get(int id);

    }
}
