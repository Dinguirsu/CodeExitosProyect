using Microsoft.AspNetCore.Mvc;

namespace CodeExitosProyect.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
