using Microsoft.AspNetCore.Mvc;
using Projeto_MVC.Models;
using System.Diagnostics;

namespace Projeto_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Entra na View Index e realiza as ações usando a pasta Home
        public IActionResult Index()
        {
            return View();
        }

        //Entra na View Privacy e realiza as ações usando a pasta Home
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
