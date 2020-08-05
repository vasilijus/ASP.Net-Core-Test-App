using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MovieAppTest.Controllers
{
    public class HelloWorldController : Controller
    {
        // public string Index() { return "Hello Index"; }
        
        public IActionResult Index()
        {
            return View();
        }
        // public string Welcome() { return "Index.Welcome()"; }
        
        /// <summary>
        /// https://localhost:5001/HelloWorld/Welcome?name=Sergio&numTimes=5
        /// </summary>
        /// <param name="name"></param>
        /// <param name="numTimes"></param>
        /// <returns></returns>
        public IActionResult Welcome( string name, int numTimes = 1 )
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}