using Microsoft.AspNetCore.Mvc;
using Proffessional_Portfolio.DAL.Context;

namespace Proffessional_Portfolio.ViewComponents
{
	public class _ExperienceComponentPartial : ViewComponent
	{
		MyPortfolioContext _context;

		public IViewComponentResult Invoke()
		{

			_context = new MyPortfolioContext();
			var values= _context.Experiences.ToList();
			return View(values);
		}
	}
}
