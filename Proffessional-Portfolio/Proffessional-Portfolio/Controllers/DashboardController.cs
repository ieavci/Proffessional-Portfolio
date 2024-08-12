using Microsoft.AspNetCore.Mvc;
using Proffessional_Portfolio.DAL.Context;

namespace Proffessional_Portfolio.Controllers
{
	public class DashboardController : Controller
	{
		MyPortfolioContext _context=new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = _context.Experiences.Count();
			ViewBag.v2 = _context.Skills.Count();
			ViewBag.v3 = _context.Messages.Count();
			ViewBag.v4 = _context.Testimonials.Count();
			return View();
		}
	}
}
