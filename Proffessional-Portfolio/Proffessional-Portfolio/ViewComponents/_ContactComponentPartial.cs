using Microsoft.AspNetCore.Mvc;

namespace Proffessional_Portfolio.ViewComponents
{
	public class _ContactComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke() {  return View(); }
	}
}
