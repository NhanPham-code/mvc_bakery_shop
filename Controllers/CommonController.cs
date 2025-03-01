using Microsoft.AspNetCore.Mvc;

namespace BakeryShop.Controllers
{
    public class CommonController : Controller
    {
        public IActionResult Forgot()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Verify()
        {
            return View();
        }
        
    }
}
