using Microsoft.AspNetCore.Mvc;

namespace Lession01.mvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
