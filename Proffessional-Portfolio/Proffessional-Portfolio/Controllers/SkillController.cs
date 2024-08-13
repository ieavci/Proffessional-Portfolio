using Microsoft.AspNetCore.Mvc;
using Proffessional_Portfolio.DAL.Context;
using Proffessional_Portfolio.DAL.Entities;

namespace Proffessional_Portfolio.Controllers
{
	public class SkillController : Controller
	{
		MyPortfolioContext _context=new MyPortfolioContext();
		public IActionResult Index()
		{
			var values=_context.Skills.ToList();
			return View(values);
		}


		[HttpGet]
		public IActionResult CreateSkill()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateSkill(Skill sk)
		{
			var skill = _context.Skills;

			if (skill==null)
			{
				return NotFound();
			}

			_context.Add(sk);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult DeleteSkill(int id)
		{
			var skill = _context.Skills.Find(id);

			if (skill == null)
			{
				return NotFound();
			}
			_context.Remove(skill);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}


		[HttpGet]
		public IActionResult UpdateSkill(int id)
		{
			var skill= _context.Skills.Find(id);
			return View(skill);
		}
		[HttpPost]
		public IActionResult UpdateSkill(Skill sk)
		{
			var skill = _context.Skills.Find(sk.SkillId);
			if (skill == null)
			{
				return NotFound();
			}
			
			skill.Value = sk.Value;
			skill.Title = sk.Title;

			_context.SaveChanges();
			
			return RedirectToAction("Index");
		}

	}
}
