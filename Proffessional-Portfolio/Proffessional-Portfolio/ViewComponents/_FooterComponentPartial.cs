using Microsoft.AspNetCore.Mvc;

namespace Proffessional_Portfolio.ViewComponents
{
	public class _FooterComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke() {  return View(); }
	}
}
