using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassScheduling.Models
{
	public class Course
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public string ID { get; set; }
		public int Credits { get; set; }
		[Display(Name = "Course Name")]
		[Range(0, 6)]
		public string CourseName { get; set; }
		public ICollection<SEMESTER> SemestersOffered { get; set; }

		// I'm not sure about this one. Is it a navigation property if
		// it's a list of its own entity
		public virtual ICollection<Course> Prerequisites { get; set; }
		public virtual ICollection<Class> Classes { get; set; }
		public virtual ICollection<Major> Majors { get; set; }
	}
}
