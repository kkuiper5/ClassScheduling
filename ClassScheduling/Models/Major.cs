using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassScheduling.Models
{
    public class Major
    {
  //      public Major(string majorID, string majorName, List<Course> majorCourses)
		//{
		//	MajorID = majorID;
		//	MajorName = majorName;
		//	MajorCourses = majorCourses;
		//}

		public string ID { get; set; }
		[Required]
		[Display(Name = "Major")]
		public string MajorName { get; set; }

		public virtual ICollection<Course> MajorCourses { get; set; }
		public virtual ICollection<Student> Students { get; set; }
	}
}
