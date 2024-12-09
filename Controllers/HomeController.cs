using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Swag.Models;
using System.Diagnostics;

namespace Swag.Controllers
{
    // Apply [Authorize] to the entire controller to protect all actions in this controller
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // This action will be accessible only to authenticated users
        public IActionResult Index()
        {
            return View();
        }

        // This action will be accessible only to authenticated users
        public IActionResult Privacy()
        {
            return View();
        }

        // This action will be accessible to users in the "Admin" role only
        [Authorize(Roles = "Admin")]
        public IActionResult AdminDashboard()
        {
            return View();
        }

        // This action will not allow unauthorized users or users without the "Admin" role to access
        [Authorize(Roles = "Admin")]
        public IActionResult AdminSettings()
        {
            return View();
        }

        // This action will be accessible to authenticated users, but for error handling
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
