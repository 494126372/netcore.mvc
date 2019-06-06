using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMvc.Models;

namespace MyMvc.Controllers
{
    //  [Route("/test")]
    public class HomeController : Controller
    {
        //  [Route("")]
        //   [Route("/test/home")]
        public IActionResult Index()
        {
            return View();
        }
         [Route("/t/t")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
