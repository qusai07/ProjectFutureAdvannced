using Microsoft.AspNetCore.Mvc;

namespace ProjectFutureAdvannced.Controllers
    {
    public class HomeController : Controller
        {
        public IActionResult Index()
            {
            return View();
            }
        [HttpGet]
        public IActionResult Login()
            {
            return View();
            }
        [HttpGet]
        public IActionResult SignUp()
            {
            return View();
            }
        }
    }
