using Microsoft.AspNetCore.Mvc;
using RecipeWebMvc.Models;
using System.Diagnostics;
using System.Text.Encodings.Web;

namespace RecipeWebMvc.Controllers
{
    public class HomeController : Controller
    {
        // 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }



        public IActionResult Creator()
        {
            
            
            return View();
        }
    }
}



