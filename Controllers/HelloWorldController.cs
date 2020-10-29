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

        public string Welcome(string name, string city)
        {
            //HtmlEncoder.Default.Encode protects the app from malicious input, namely Javascript.
            return HtmlEncoder.Default.Encode($"Welcome {name}. Glad you could make it from {city}");
        }
    }
}