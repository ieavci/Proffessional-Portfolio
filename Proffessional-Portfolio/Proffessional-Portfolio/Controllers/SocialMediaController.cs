using Microsoft.AspNetCore.Mvc;
using Proffessional_Portfolio.DAL.Context;
using Proffessional_Portfolio.DAL.Entities;

namespace Proffessional_Portfolio.Controllers
{
	public class SocialMediaController : Controller
	{
		MyPortfolioContext _context = new MyPortfolioContext();
		public IActionResult Index()
		{
			var values = _context.SocailMedias.ToList();
			return View(values);
		}


		[HttpGet]
		public IActionResult CreateSocialMedia()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateSocialMedia(SocailMedia rf)
		{
			var sm = _context.SocailMedias;
			if (sm == null)
			{
				return NotFound();
			}
			_context.Add(rf);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateSocialMedia(int id)
		{
			var sm = _context.SocailMedias.Find(id);

			if (sm != null)
			{
				return View(sm);
			}

			return NotFound();
		}

		[HttpPost]
		public IActionResult UpdateSocialMedia(SocailMedia rf)
		{
			var sm = _context.SocailMedias.Find(rf.SocailMediaId);
			if (sm == null)
			{
				return NotFound();
			}
			sm.Url = rf.Url;
			sm.Title = rf.Title;
			sm.Icon = rf.Icon;


			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult DeleteSocialMedia(int id)
		{
			var sm = _context.SocailMedias.Find(id);

			if (sm == null)
			{
				return NotFound();
			}

			_context.Remove(sm);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
