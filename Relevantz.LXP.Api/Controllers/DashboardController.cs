using Relevantz.LXP.Core.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Relevantz.LXP.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _dashboardService;
        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        [HttpGet("/lxp/admin/DashboardDetails")]
        public IActionResult AdminDashboard()
        {
            var admin = _dashboardService.GetAdminDashboardDetails();
            return Ok(admin);
        }

    }

}