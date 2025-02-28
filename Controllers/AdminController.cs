using Microsoft.AspNetCore.Mvc;

namespace BakeryShop.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminOrder()
        {
            return View();
        }
        public IActionResult AccountManagement()
        {
            return View();
        }

        public IActionResult ProductManagement()
        {
            return View();
        }
    }
}
