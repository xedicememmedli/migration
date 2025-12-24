using Microsoft.AspNetCore.Mvc;

namespace Front_to_Back.Controllers
{
    public class _404Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
