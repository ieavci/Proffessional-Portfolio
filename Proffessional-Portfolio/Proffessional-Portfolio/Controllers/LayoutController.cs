using Microsoft.AspNetCore.Mvc;

namespace Proffessional_Portfolio.Controllers
{
	public class LayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
