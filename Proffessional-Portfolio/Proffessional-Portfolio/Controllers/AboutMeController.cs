using Microsoft.AspNetCore.Mvc;
using Proffessional_Portfolio.DAL.Context;
using Proffessional_Portfolio.DAL.Entities;

namespace Proffessional_Portfolio.Controllers
{
	public class AboutMeController : Controller
	{
		MyPortfolioContext _context = new MyPortfolioContext();
		public IActionResult Index()
		{
			var value = _context.Abouts.FirstOrDefault();
			return View(value);
		}

		[HttpGet]
		public IActionResult UpdateAbout(int id)
		{
			var aboutItem = _context.Abouts.Find(id);
			if (aboutItem == null)
			{
				return NotFound();
			}
			return View(aboutItem);
		}
		[HttpPost("UpdateAbout")]
		public IActionResult UpdateAbout(About ab)
		{
			var aboutItem = _context.Abouts.Find(ab.AboutId);

			if (aboutItem != null)
			{
				aboutItem.Title = ab.Title;
				aboutItem.SubDescription = ab.SubDescription;
				aboutItem.Details = ab.Details;
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return NotFound();
		}
	}
}
