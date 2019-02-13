using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassScheduling.Models
{
	public class Student
	{
		//public Student(string studentID, string first, string last,
		//	string id, string email, Address address, List<Major> majors,
		//	List<Schedule> schedules)
		//{
		//	StudentID = id;
		//	FirstName = first;
		//	LastName = last;
		//	EmailAddress = email;
		//	Address = address;
		//	Majors = majors;
		//	Schedules = schedules;
		//}

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

		public virtual Address Address { get; set; }
		public virtual ICollection<Major> Majors { get; set; }
		public virtual ICollection<Enrollment> Enrollments { get; set; }
	}
}

