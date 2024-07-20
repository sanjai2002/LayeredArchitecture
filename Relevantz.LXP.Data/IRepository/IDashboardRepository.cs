using Relevantz.LXP.Common.Entities;
using Relevantz.LXP.Common.ViewModels;


namespace Relevantz.LXP.Data.IRepository
{
    public interface IDashboardRepository
    {

        public List<Learner> GetNoOfLearners();
        public List<Course> GetNoOfCourse();

    }
    
    }