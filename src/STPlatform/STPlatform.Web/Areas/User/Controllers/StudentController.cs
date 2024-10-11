using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace STPlatform.Web.Areas.User.Controllers
{
    [Area("User")]
    [Authorize]
    public class StudentController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult AskQuestion()
        {
            return View();
        }
    }
}
