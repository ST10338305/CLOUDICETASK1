﻿using Microsoft.AspNetCore.Mvc;

namespace RecipeWebMvc.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
