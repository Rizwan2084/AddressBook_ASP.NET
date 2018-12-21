using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Technovert.Models;


namespace Technovert.Controllers
{
	public class HomeController : Controller
	{
		private readonly ISession session;

		public HomeController(IHttpContextAccessor httpContextAccessor)
		{
			this.session = httpContextAccessor.HttpContext.Session;
		}

		public IActionResult Index(int? ID)
		{
			var allContacts = GetListOfContacts();
			var clickedContact = new ContactDetails();

			if (ID.HasValue)
			{
				clickedContact = allContacts.Where(s => s.ID == ID).FirstOrDefault();
				ViewData["isClicked"] = true;
			}
			else
				ViewData["isClicked"] = false;

			
			session.SetString("clickedContact", JsonConvert.SerializeObject(clickedContact));
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Add(ContactDetails contactDetails)
		{

			if (ModelState.IsValid)
			{
				var existingItemsJsonData = session.GetString("contacts");
				List<ContactDetails> contacts = new List<ContactDetails>();
				if (existingItemsJsonData != null)
				{
					contacts = JsonConvert.DeserializeObject<List<ContactDetails>>(existingItemsJsonData);
				}
				if (contacts.Count == 0)
					contactDetails.ID = 1;
				else
					contactDetails.ID = contacts[contacts.Count - 1].ID + 1;
				contacts.Add(contactDetails);
				session.SetString("contacts", JsonConvert.SerializeObject(contacts));
				return RedirectToAction("Index");
			}
			else
			{
				return View(contactDetails);

			}

		}

		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}

		public IActionResult Edit(int? id)
		{

			ContactDetails contact = GetListOfContacts().Find(x => x.ID == id);
			return View(contact);

		}

		[HttpPost]
		public IActionResult Edit(int id, ContactDetails contactDetails)
		{
			var contacts = GetListOfContacts();
			ContactDetails editContact = contacts.Find(x => x.ID == contactDetails.ID);
			editContact.Name = contactDetails.Name;
			editContact.Mobile = contactDetails.Mobile;
			editContact.Email = contactDetails.Email;
			editContact.Landline = contactDetails.Landline;
			editContact.Website = contactDetails.Website;
			session.SetString("contacts", JsonConvert.SerializeObject(contacts));
			ViewBag.message = "your contact has been edited successfully";
			return RedirectToAction("Index");

		}

		public IActionResult Delete(int id)
		{

			var allContacts = GetListOfContacts();
			ContactDetails contact = allContacts.Find(x => x.ID == id);
			allContacts.Remove(contact);
			session.SetString("contacts", JsonConvert.SerializeObject(allContacts));
			return RedirectToAction("Index");
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


		[NonAction]
		private List<ContactDetails> GetListOfContacts()
		{
			var contactsInSession = session.GetString("contacts");
			if (contactsInSession != null)
				return JsonConvert.DeserializeObject<List<ContactDetails>>(contactsInSession);
			else
				return null;
		}

	}
}
