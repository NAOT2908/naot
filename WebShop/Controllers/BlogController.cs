using Microsoft.AspNetCore.Mvc;

namespace WebShop.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
