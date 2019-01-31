using System;
using System.Collections.Generic;

namespace ClassScheduling.Models
{
	public class Course
	{
		public Course(string courseID, int credits, string courseName,
			List<Course> prereqs, List<SEMESTER> semestersOffered)
		{
			CourseID = courseID;
			Credits = credits;
			CourseName = courseName;
			Prerequisites = prereqs;
			SemestersOffered = semestersOffered;
		}

		public string CourseID { get; set; }
		public int Credits { get; set; }
		public string CourseName { get; set; }
		public List<Course> Prerequisites { get; set; }
		public List<SEMESTER> SemestersOffered { get; set; }
	}
}
