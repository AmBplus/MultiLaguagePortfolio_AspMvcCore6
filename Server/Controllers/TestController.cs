using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
