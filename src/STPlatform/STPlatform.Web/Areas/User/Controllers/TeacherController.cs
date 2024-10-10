using Microsoft.AspNetCore.Mvc;

namespace STPlatform.Web.Areas.User.Controllers
{
    [Area("User")]
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}