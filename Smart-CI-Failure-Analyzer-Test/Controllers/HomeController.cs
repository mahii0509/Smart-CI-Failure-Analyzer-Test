using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Smart_CI_Failure_Analyzer_Test.Models;

namespace Smart_CI_Failure_Analyzer_Test.Controllers
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
        public IActionResult Privacy()
        {
            string text = null;
            text.Contains();
            return View();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
