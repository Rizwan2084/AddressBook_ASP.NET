using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Technovert.Models
{
	public class ContactDetails
	{
		public int ID { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Email { get; set; }

		[Required]
		[RegularExpression(@"^[6-9]+[0-9""'\s-]*$")]
		[StringLength(10)]
		public string Mobile { get; set; }

		
		[RegularExpression(@"^[0-9""'\s-]*$")]
		[StringLength(10)]
		public string Landline { get; set; }
		public string Website { get; set; }

		[Required]
		public string Address { get; set; }
	}
}
