using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;

namespace HelloASPDotNET.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/hello")]
        public IActionResult Welcome(string name = "World")
        {
            ViewBag.person = name;
            return View();
        }
    }
}
