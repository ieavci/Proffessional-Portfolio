using Microsoft.AspNetCore.Mvc;
using Proffessional_Portfolio.DAL.Context;

namespace Proffessional_Portfolio.Controllers
{
	public class MessageController : Controller
	{
		MyPortfolioContext _context = new MyPortfolioContext();
		public IActionResult Index()
		{
			var values = _context.Messages.ToList();
			return View(values);
		}

		public IActionResult ChangeStateTure(int id)
		{
			
			var values = _context.Messages.Find(id);
			if (values == null)
			{
				return NotFound();
			}

			values.isRead = true;
			_context.SaveChanges();
			return RedirectToAction("Index");
		}


		public IActionResult ChangeStateFalse(int id)
		{
			
			var values = _context.Messages.Find(id);
			if (values == null)
			{
				return NotFound();
			}

			values.isRead = false;
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult DeleteMessage(int id)
		{
			var messages = _context.Messages.Find(id);
			if (messages==null)
			{
				return NotFound();
			}

			_context.Messages.Remove(messages);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult OpenMail(int id)
		{
			var values= _context.Messages.Find(id);
			if (values==null)
			{
				return NotFound();
			}
			return View(values);
		}

	}
}
