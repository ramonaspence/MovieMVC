using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MovieMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //GET: /HelloWorld/Welcome

        public IActionResult Welcome(string name, int numTimes)
        {
            ViewData["Message"] = "Welcome, " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}