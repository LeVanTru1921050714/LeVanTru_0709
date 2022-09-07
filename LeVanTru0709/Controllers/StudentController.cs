using Microsoft.AspNetCore.Mvc;

namespace LeVanTru0709.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
