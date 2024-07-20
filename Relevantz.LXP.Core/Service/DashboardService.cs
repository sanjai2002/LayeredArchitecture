using Relevantz.LXP.Common.ViewModels;
using Relevantz.LXP.Core.IServices;
using Relevantz.LXP.Data.IRepository;

namespace Relevantz.LXP.Core.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly IDashboardRepository _dashboardRepository;

        public DashboardService(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository;
        }

         public AdminDashboardViewModel GetAdminDashboardDetails()
        {
            var AdminDashboard = new AdminDashboardViewModel
            {
             NoOfLearners = _dashboardRepository.GetNoOfLearners().Count(),
             NoOfCourse = _dashboardRepository.GetNoOfCourse().Count(),
            };
            return AdminDashboard;
        }


    }
    
    }