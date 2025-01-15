using Microsoft.AspNetCore.Mvc;

namespace LayoutViewsExample.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("about-company")]
        public IActionResult About()
        {
            return View();
        }
        [Route("contact-support")]

        public IActionResult Contact()
        {
            return View();
        }
    }
}
