using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Technovert.Models;

namespace Technovert.Controllers
{
	public class ContactDetailsController : Controller
	{
		private readonly TechnovertContext _context;

		public ContactDetailsController(TechnovertContext context)
		{
			_context = context;
		}

		// GET: ContactDetails
		public async Task<IActionResult> Index()
		{
			var contacts = from m in _context.ContactDetails
						   select m;

			var contactsList = new ContactList();
			contactsList.Contacts = await contacts.ToListAsync();
			return View(contactsList);
		}

		// GET: ContactDetails/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var contactDetails = await _context.ContactDetails
				.FirstOrDefaultAsync(m => m.ID == id);
			if (contactDetails == null)
			{
				return NotFound();
			}

			return View(contactDetails);
		}

		// GET: ContactDetails/Create
		public IActionResult Add()
		{
			return View();
		}

		// POST: ContactDetails/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
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

		// GET: ContactDetails/Edit/5
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

		// POST: ContactDetails/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
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

		// GET: ContactDetails/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var contactDetails = await _context.ContactDetails
				.FirstOrDefaultAsync(m => m.ID == id);
			if (contactDetails == null)
			{
				return NotFound();
			}

			return View(contactDetails);
		}

		// POST: ContactDetails/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var contactDetails = await _context.ContactDetails.FindAsync(id);
			_context.ContactDetails.Remove(contactDetails);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool ContactDetailsExists(int id)
		{
			return _context.ContactDetails.Any(e => e.ID == id);
		}
	}
}
