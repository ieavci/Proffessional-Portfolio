using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proffessional_Portfolio.DAL.Context;

namespace Proffessional_Portfolio.ViewComponents
{
	public class _FeatureComponentPartial : ViewComponent
	{
		MyPortfolioContext _context;
		
		
		public  IViewComponentResult Invoke()
		{
			_context=new MyPortfolioContext();
			var values = _context.Features.ToList();
			return View(values);
		}
	}
}
