using Microsoft.AspNetCore.Mvc;

namespace NiceToDev.Schedules.Controllers
{
    public class SchedulesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
