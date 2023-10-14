using Microsoft.AspNetCore.Mvc;

namespace JuanMain.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
