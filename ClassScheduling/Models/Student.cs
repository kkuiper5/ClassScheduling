using System;
using System.Collections.Generic;

namespace ClassScheduling.Models
{
	public class Student
	{
		public Student(string studentID, string first, string last,
			string id, string email, Address address, List<Major> majors,
			List<Schedule> schedules)
		{
			StudentID = id;
			FirstName = first;
			LastName = last;
			EmailAddress = email;
			Address = address;
			Majors = majors;
			Schedules = schedules;
		}

		public string StudentID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }
		public Address Address { get; set; }
		public List<Major> Majors { get; set; }
		public List<Schedule> Schedules { get; set; }
	}
}

