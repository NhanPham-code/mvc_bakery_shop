﻿using Microsoft.AspNetCore.Mvc;

namespace BakeryShop.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
