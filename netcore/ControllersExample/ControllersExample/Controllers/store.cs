using Microsoft.AspNetCore.Mvc;

namespace ControllersExample.Controllers
{
    public class storeController : Controller
    {
        [Route("store/books")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
