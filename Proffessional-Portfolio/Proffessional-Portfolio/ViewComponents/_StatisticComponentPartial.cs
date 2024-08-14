using Microsoft.AspNetCore.Mvc;
using Proffessional_Portfolio.DAL.Context;

namespace Proffessional_Portfolio.ViewComponents
{
	public class _StatisticComponentPartial : ViewComponent
	{
		MyPortfolioContext _context=new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			
			var experienceCount = _context.Experiences.Count();
			var portfolioCount = _context.Portfolios.Count();
			var skillsCount = _context.Skills.Count();
			var tesimonialCount=_context.Testimonials.Count();
			
			ViewBag.ExperienceCount = experienceCount;
			ViewBag.PortfolioCount = portfolioCount;
			ViewBag.SkillsCount = skillsCount;
			ViewBag.TestimonialCount = tesimonialCount;

			return View(); 
		}


	}
}
