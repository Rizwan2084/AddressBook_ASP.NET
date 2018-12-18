using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Technovert.Models
{
	public static class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new TechnovertContext(
				serviceProvider.GetRequiredService<
					DbContextOptions<TechnovertContext>>()))
			{
				// Look for any movies.
				if (context.ContactDetails.Any())
				{
					return;   // DB has been seeded
				}

				context.ContactDetails.AddRange(
					new ContactDetails
					{
						Name = "Rizwan",
						Email = "rijju473@gmail.com",
						Mobile = "7675930766",
						Landline = "0401234567",
						Website = "www.google.com",
						Address = "ABC Colony, Madhapur, Hyderabad"
					}
				);
				context.SaveChanges();
			}
		}
	}
}