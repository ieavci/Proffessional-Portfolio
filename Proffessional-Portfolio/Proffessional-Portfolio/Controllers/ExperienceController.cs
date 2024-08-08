using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Proffessional_Portfolio.DAL.Context;
using Proffessional_Portfolio.DAL.Entities;

namespace Proffessional_Portfolio.Controllers
{
	public class ExperienceController : Controller
	{
		MyPortfolioContext _context = new MyPortfolioContext();
		public IActionResult ExperienceList()
		{

			var values = _context.Experiences.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateExperience()
		{
			return View();
		}

		[HttpPost("Create")]
		public IActionResult CreateExperience(Experience exp)
		{
			var experience = _context.Experiences;
			if (experience != null)
			{
				experience.Add(exp);
			}
			else
			{
				return BadRequest();
			}

			_context.SaveChanges();
			return RedirectToAction("ExperienceList");

		}

		public IActionResult DeleteExperience(int id)
		{
			var experience = _context.Experiences.Find(id);
			_context.Experiences.Remove(experience);
			_context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}



		[HttpGet]
		public IActionResult UpdateExperience(int id)
		{
			var experience = _context.Experiences.Find(id);

			return View(experience);
		}

		[HttpPost("UpdateExperience")]
		public IActionResult UpdateExperience(Experience exp)
		{
			var experience = _context.Experiences.Find(exp.ExperienceID);

			if (experience != null)
			{
				experience.Head=exp.Head;
				experience.Title=exp.Title;
				experience.Date=exp.Date;
				experience.Description=exp.Description;


				_context.SaveChanges();
				return RedirectToAction("ExperienceList");
			}
			return NotFound();
			
		}
	}
}
