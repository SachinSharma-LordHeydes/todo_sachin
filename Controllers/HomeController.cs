using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using todosachin.Data;
using todosachin.Models;

namespace todosachin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;


        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
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
            //return View(new TaskList());
            if (Request.Method == "POST")
            {
                var tlist = new TaskList
                {
                    Task = Request.Form["task"],
                    Description = Request.Form["description"],
                    Status = Request.Form["status"],
                    Test = Request.Form["test"]
                };
                Console.WriteLine(tlist);
                _context.Tasklist.Add(tlist);
                _context.SaveChanges();
                Console.WriteLine("Form Submitted");
            }
            var tasklist = _context.Tasklist.ToList();
            return View(tasklist);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
