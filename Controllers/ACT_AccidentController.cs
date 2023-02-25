using Microsoft.AspNetCore.Mvc;

namespace Road_Safety_Project.Controllers
{
    public class ACT_AccidentController : Controller
    {
        private IConfiguration Configuration;
        public IActionResult Index()
        {

            return View();
        }
    }
}
