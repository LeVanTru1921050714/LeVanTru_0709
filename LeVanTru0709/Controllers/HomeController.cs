using LeVanTru0709.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LeVanTru0709.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string FullName, String Email, int Age)
        {
            ViewBag.student = "Hello: " + FullName + "-" + Email + "-" +Age;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
