using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using todosachin.Models;

namespace todosachin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        public IActionResult Privacy()
        {
            //ViewData["Title"] = "Learn Dot net.";
            //ViewData["Description"] = "Getting statarted with dotnet.";
            //ViewData["Status"] = "Done";

            //ViewBag.Task1 = "Start Projest";
            //ViewBag.Description1 = "Start TODO in web Dev";
            //ViewBag.Status1= "InProgress";

            ////through ViewModel
            //var taskList = new List<TaskList>
            //{
            //    new TaskList { task = "Learn Dot net", Description = "Getting started with dotnet", Status = "Done" },
            //    new TaskList { task = "Learn Dot net", Description = "Getting started with dotnet", Status = "Done" },
            //    new TaskList { task = "Learn Dot net", Description = "Getting started with dotnet", Status = "Done" }
            //};

            //return View(taskList);
            return View(new TaskList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
