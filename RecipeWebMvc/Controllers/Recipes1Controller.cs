using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class Recipes1Controller : Controller
{
    private const string CorrectPassword = "password"; // Change to your correct password

    public IActionResult Index()
    {
        // Check if the user is authenticated
        if (!User.Identity.IsAuthenticated)
        {
            // Redirect to login page or display unauthorized view
            return RedirectToAction("Home");
        }

        // If the user is authenticated, proceed to the Index view
        return View();
    }

    // Other action methods...

    [HttpPost]
    public async Task<IActionResult> Login(string username, string password)
    {
        // Check if the password is correct
        if (password != CorrectPassword)
        {
            ModelState.AddModelError(string.Empty, "Incorrect password.");
            return View("Index");
        }

        // Password is correct, proceed with authentication
        // For demonstration, you can set a claim to indicate authentication
        // Example: await HttpContext.SignInAsync(...);

        // Redirect to Recipes/Index after successful login
        return RedirectToAction("Index");
    }
}