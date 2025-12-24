using Microsoft.AspNetCore.Mvc;

namespace Front_to_Back.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
