using Microsoft.AspNetCore.Mvc;
using Proffessional_Portfolio.DAL.Context;

namespace Proffessional_Portfolio.ViewComponents
{
	public class _StatisticComponentPartial:ViewComponent
	{
		MyPortfolioContext _context;
		public IViewComponentResult Invoke() { 
			_context = new MyPortfolioContext();
			
			return View();
		}
	}
}
