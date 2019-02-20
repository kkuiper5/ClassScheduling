using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassScheduling.Models
{
	public class Student
	{
		// These StudentIDs will be in the A00000000 form
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public string ID { get; set; }
		[Required]
		[StringLength(50)]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }
		[Required]
		[StringLength(50)]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }
		[Required]
		[StringLength(100)]
		[Display(Name = "Email Address")]
		public string EmailAddress { get; set; }
		public string AddressID { get; set; }
		// This will change
		public List<String> Majors { get; set; }

		public virtual Address Address { get; set; }
		//public virtual ICollection<Major> Majors { get; set; }
		public virtual ICollection<Enrollment> Enrollments { get; set; }
	}
}

