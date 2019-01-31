using System;
namespace ClassScheduling.Models
{
	public class Instructor
	{
		public Instructor(string instructorID, string first, string last, string email)
		{
			InstructorID = instructorID;
			FirstName = first;
			LastName = last;
			EmailAddress = email;
		}

		public string InstructorID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }
	}
}

