using Microsoft.AspNetCore.Mvc;
using Proffessional_Portfolio.DAL.Context;
using Proffessional_Portfolio.DAL.Entities;

namespace Proffessional_Portfolio.Controllers
{
	public class FeatureController : Controller
	{
		MyPortfolioContext _context=new MyPortfolioContext();
		public IActionResult Index()
		{
			var values= _context.Features.FirstOrDefault();
			return View(values);
		}

		[HttpPost]
		public IActionResult Index(Feature feature)
		{
			var featureItem=_context.Features.Find(feature.FeatureId);
			if (featureItem==null)
			{
				return NotFound();
			}

			featureItem.Title = feature.Title;
			featureItem.Description = feature.Description;	

			_context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
