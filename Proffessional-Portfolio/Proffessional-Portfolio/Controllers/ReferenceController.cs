using System.Security.Cryptography.Xml;
using Microsoft.AspNetCore.Mvc;
using Proffessional_Portfolio.DAL.Context;
using Proffessional_Portfolio.DAL.Entities;

namespace Proffessional_Portfolio.Controllers
{
	public class ReferenceController : Controller
	{

		MyPortfolioContext _context=new MyPortfolioContext();
		public IActionResult Index()
		{
			var values=_context.Testimonials.ToList();
			return View(values);
		}


		[HttpGet]
		public IActionResult CreateReference()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateReference(Testimonial rf)
		{
			var reference = _context.Testimonials;
			if (reference==null)
			{
				return NotFound();
			}
			_context.Add(rf);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateReference(int id)
		{
			var reference = _context.Testimonials.Find(id);

			if (reference!=null)
			{
				return View(reference);
			}

			return NotFound();
		}

		[HttpPost]
		public IActionResult UpdateReference(Testimonial rf)
		{
			var reference = _context.Testimonials.Find(rf.TestimonialId);
			if (reference == null)
			{
				return NotFound();
			}
			reference.NameSurname=rf.NameSurname;
			reference.Title=rf.Title;
			reference.Description=rf.Description;
			reference.ImageUrl=rf.ImageUrl;


			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult Deletereference(int id)
		{
			var reference = _context.Testimonials.Find(id);

			if (reference==null)
			{
				return NotFound();
			}

			_context.Remove(reference);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
