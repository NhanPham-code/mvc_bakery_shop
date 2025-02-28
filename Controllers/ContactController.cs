using Microsoft.AspNetCore.Mvc;

namespace BakeryShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
