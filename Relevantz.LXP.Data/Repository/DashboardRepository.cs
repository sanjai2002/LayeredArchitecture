using System.Data.Entity;
using Relevantz.LXP.Common.Entities;
using Relevantz.LXP.Common.ViewModels;
using Relevantz.LXP.Data.IRepository;


namespace Relevantz.LXP.Data.Repository
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly LXPDbContext _lXPDbContext;
        public DashboardRepository(LXPDbContext lXPDbContext)
        {
            _lXPDbContext = lXPDbContext;
        }

        public List<Learner> GetNoOfLearners()
        {
            return _lXPDbContext.Learners.Where(Learner => Learner.Role != "Admin").ToList();
        }

        public List<Course> GetNoOfCourse()
        {
            return _lXPDbContext.Courses.ToList();
        }





    }

}