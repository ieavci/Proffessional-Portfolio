using Microsoft.AspNetCore.Mvc;
using Proffessional_Portfolio.DAL.Context;
using Proffessional_Portfolio.DAL.Entities;

namespace Proffessional_Portfolio.Controllers
{
	public class ContactController : Controller
	{
		MyPortfolioContext _context = new MyPortfolioContext();
		public IActionResult Index()
		{

			var values = _context.Contacts.FirstOrDefault();

            if (values==null)
            {
				values = new Contact();
				values.Title = "Add Title";
				values.Email1 = "Add Email";
				values.Phone1 = "Add Phone Number";
				values.Address = "Add Address";
				values.Description = "Add Description";

				_context.Contacts.Add(values);
				_context.SaveChanges();
            }
            return View(values);
		}


		[HttpGet]
		public IActionResult UpdateContact(int id)
		{
			var contactItem = _context.Contacts.Find(id);

			if (contactItem != null)
			{
				return View(contactItem);
			}

			return NotFound();
		}

		[HttpPost]
		public IActionResult UpdateContact(Contact rf)
		{
			var reference = _context.Contacts.Find(rf.ContactID);
			if (reference == null)
			{
				return NotFound();
			}
			reference.Title = rf.Title;
			reference.Description = rf.Description;
			reference.Phone1 = rf.Phone1;
			reference.Email1 = rf.Email1;
			reference.Address = rf.Address;


			_context.SaveChanges();
			return RedirectToAction("Index");
		}

	
	}
}
