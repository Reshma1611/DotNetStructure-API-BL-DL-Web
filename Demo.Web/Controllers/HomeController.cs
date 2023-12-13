using Demo.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo.Web.Controllers
{
    //[Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //[HttpGet]
        //[Route("Index")]
        public IActionResult Index()
        {
            string viewbag = "viewbag";
            string viewdata = "viewdata";
            string tempdata = "tempdata";
            ViewBag.msg1 = viewbag;
            ViewData["msg"] = viewdata;
            TempData["msg"] = tempdata;
            return View();
        }

        //[HttpGet("Home")]
        //public IActionResult Home()
        //{
        //    return View();
        //}

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