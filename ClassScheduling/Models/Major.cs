using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassScheduling.Models
{
    public class Major
    {
		public string ID { get; set; }
		[Required]
		[Display(Name = "Major")]
		public string MajorName { get; set; }

		public virtual ICollection<Course> MajorCourses { get; set; }
		public virtual ICollection<Student> Students { get; set; }
	}
}
