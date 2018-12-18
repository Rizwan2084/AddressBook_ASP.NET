using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Technovert.Models;


namespace Technovert.Controllers
{
	public class HomeController : Controller
	{
		private readonly TechnovertContext _context;

		public HomeController(TechnovertContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index(int? ID)
		{

			var contacts = from m in _context.ContactDetails
						   select m;

			var clickedContact = new ContactDetails();
			if (ID.HasValue)
			{
				clickedContact = contacts.Where(s => s.ID == ID).FirstOrDefault();
				ViewData["isClicked"] = true;
			}
			else
				ViewData["isClicked"] = false;

			var contactsList = new ContactList();
			contactsList.Contacts = await contacts.ToListAsync();
			contactsList.clickedContact = clickedContact;
			return View(contactsList);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Add([Bind("ID, Name, Email, Mobile, Landline, Website, Address")] ContactDetails contactDetails)
		{
			if (ModelState.IsValid)
			{
				_context.Add(contactDetails);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(contactDetails);
		}

		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}

		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var contactDetails = await _context.ContactDetails.FindAsync(id);
			if (contactDetails == null)
			{
				return NotFound();
			}
			return View(contactDetails);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Email,Mobile,Landline,Website,Address")] ContactDetails contactDetails)
		{
			if (id != contactDetails.ID)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(contactDetails);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!ContactDetailsExists(contactDetails.ID))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(contactDetails);
		}

		public async Task<IActionResult> Delete(int id)
		{
			var contactDetails = await _context.ContactDetails.FindAsync(id);
			_context.ContactDetails.Remove(contactDetails);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}



		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		private bool ContactDetailsExists(int id)
		{
			return _context.ContactDetails.Any(e => e.ID == id);
		}
	}
}
