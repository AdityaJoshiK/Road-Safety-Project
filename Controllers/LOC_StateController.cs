using Microsoft.AspNetCore.Mvc;

namespace Road_Safety_Project.Controllers
{
    public class LOC_StateController : Controller
    {
        public IActionResult Index()
        {
            return View("LOC_StateList");
        }
    }
}
