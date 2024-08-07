using Microsoft.AspNetCore.Mvc;

namespace Proffessional_Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
