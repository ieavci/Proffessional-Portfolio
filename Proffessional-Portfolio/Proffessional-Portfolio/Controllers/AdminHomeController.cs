using Microsoft.AspNetCore.Mvc;

namespace Proffessional_Portfolio.Controllers
{
	public class AdminHomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
