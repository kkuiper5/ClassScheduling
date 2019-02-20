using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassScheduling.Models
{
	public class Instructor
	{
		public string ID { get; set; }
		[Display(Name = "First Name")]
		public string FirstName { get; set; }
		[Display(Name = "Last Name")]
		public string LastName { get; set; }
		[Display(Name = "Email Address")]
		public string EmailAddress { get; set; }

		public virtual ICollection<Class> Classes { get; set; }
	}
}

