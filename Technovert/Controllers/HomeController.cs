using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Technovert.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Technovert.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Add([Bind("ID, Name, Email, Mobile, Landline, Website, Address")] ContactDetails contactDetails)
		{
			if (ModelState.IsValid)
			{
				//_context.Add(contactDetails);
				//await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(contactDetails);
		}

		[HttpGet]
		public IActionResult Add()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
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
	}
}
