using Microsoft.AspNetCore.Mvc;

namespace todosachin.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
