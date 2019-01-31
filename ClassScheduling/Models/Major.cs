using System;
using System.Collections.Generic;

namespace ClassScheduling.Models
{
    public class Major
    {
        public Major(string majorID, string majorName, List<Course> majorCourses)
		{
			MajorID = majorID;
			MajorName = majorName;
			MajorCourses = majorCourses;
		}

		public string MajorID { get; set; }
		public string MajorName { get; set; }
		public List<Course> MajorCourses { get; set; }
	}
}
