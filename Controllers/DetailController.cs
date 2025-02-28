using Microsoft.AspNetCore.Mvc;

namespace BakeryShop.Controllers
{
    public class DetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
