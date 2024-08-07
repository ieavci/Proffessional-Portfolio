using Microsoft.AspNetCore.Mvc;
using Proffessional_Portfolio.DAL.Context;

namespace Proffessional_Portfolio.ViewComponents
{
	public class _SkillComponentPartial : ViewComponent
	{
		MyPortfolioContext _context;
		public IViewComponentResult Invoke()
		{
			_context = new MyPortfolioContext();
			var values=_context.Skills.ToList();
			return View(values);
		}
	}
}
