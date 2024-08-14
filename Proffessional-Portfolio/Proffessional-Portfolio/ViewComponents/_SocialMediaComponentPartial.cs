using Microsoft.AspNetCore.Mvc;
using Proffessional_Portfolio.DAL.Context;

namespace Proffessional_Portfolio.ViewComponents
{
	public class _SocialMediaComponentPartial:ViewComponent
	{
		MyPortfolioContext _context=new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			var values=_context.SocailMedias.ToList();
			return View(values);
		}
	}
}
