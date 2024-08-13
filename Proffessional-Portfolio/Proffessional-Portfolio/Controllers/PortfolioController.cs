using Microsoft.AspNetCore.Mvc;
using Proffessional_Portfolio.DAL.Context;
using Proffessional_Portfolio.DAL.Entities;

namespace Proffessional_Portfolio.Controllers
{
	public class PortfolioController : Controller
	{
		MyPortfolioContext _context=new MyPortfolioContext();
		public IActionResult Index()
		{
			var values=_context.Portfolios.ToList();
			return View(values);
		}


		[HttpGet]
		public IActionResult CreatePortfolio()
		{
			return View();
		}

		[HttpPost("CreatePortfolio")]
		public IActionResult CreatePortfolio(Portfolio portf)
		{
			var portfolio= _context.Portfolios;

			if (portfolio != null)
			{
				_context.Add(portf);
			}
			else
			{
				return BadRequest();
			}
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult DeletePortfolio(int id)
		{
			var portfolio=_context.Portfolios.Find(id);

            if (portfolio==null)
            {
                return NotFound();
            }

			_context.Remove(portfolio);
			_context.SaveChanges();
			return RedirectToAction("Index");
        }

		[HttpGet]
		public IActionResult UpdatePortfolio(int id)
		{
			var portfolio = _context.Portfolios.Find(id);

			return View(portfolio);
		}
		[HttpPost]
		public IActionResult UpdatePortfolio(Portfolio portf)
		{
			var portfolio = _context.Portfolios.Find(portf.PortfolioId);

			if (portfolio == null)
			{
				return NotFound();
			}
			portfolio.Title=portf.Title;
			portfolio.Description=portf.Description;
			portfolio.SubTitle=portf.SubTitle;
			portfolio.Url=portf.Url;
			portfolio.ImageUrl=portf.ImageUrl;

			_context.SaveChanges();

			return RedirectToAction("Index");
		}


	}
}
