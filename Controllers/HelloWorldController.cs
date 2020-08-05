using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.Extensions.Logging;
using ASP.Net_Core_Test_App.Models;

namespace ASP.Net_Core_Test_App.Controllers
{
    public class HelloWorldController : Controller
    {
        
        // Quick test without views
        // public string Index() { return "This is my default action"; }
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome( string name, int ID = 1 )
        {
            // return "Welcome action method";
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

    }
}
