using Microsoft.AspNetCore.Mvc;

namespace Proffessional_Portfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutSideBarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
