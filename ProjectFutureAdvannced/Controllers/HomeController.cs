using Microsoft.AspNetCore.Mvc;
using ProjectFutureAdvannced.Models.IRepository;
using ProjectFutureAdvannced.ViewModels;

namespace ProjectFutureAdvannced.Controllers
    {
    public class HomeController : Controller
        {
        private readonly ICategoryRepository categoryRepository;
        public HomeController( ICategoryRepository categoryRepository )
        {
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
            {
            ListOfInfo listOfInfo = new ListOfInfo()
                {
                categories = categoryRepository.GetAll()
                };
            return View( listOfInfo );
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
