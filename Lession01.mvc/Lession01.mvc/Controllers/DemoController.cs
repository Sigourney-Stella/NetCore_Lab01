using Microsoft.AspNetCore.Mvc;

namespace Lession01.mvc.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
