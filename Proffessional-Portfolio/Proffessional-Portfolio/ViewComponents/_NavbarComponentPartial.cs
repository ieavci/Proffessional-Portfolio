using Microsoft.AspNetCore.Mvc;

namespace Proffessional_Portfolio.ViewComponents
{
	public class _NavbarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke() {  return View(); }
	}
}
