using Microsoft.AspNetCore.Mvc;

namespace STPlatform.Web.Areas.User.Controllers
{
    [Area("User")]
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
