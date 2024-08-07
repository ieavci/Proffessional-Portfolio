using Microsoft.AspNetCore.Mvc;

namespace Proffessional_Portfolio.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }

    }
}
