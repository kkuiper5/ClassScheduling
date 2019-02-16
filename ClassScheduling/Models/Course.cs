using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassScheduling.Models
{
	public class Course
	{
		// These CourseIDs will be in the form of CSCI000
		// per Davenport's model
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public string ID { get; set; }
		public int Credits { get; set; }
		[Display(Name = "Course Name")]
		[Range(0, 6)]
		public string CourseName { get; set; }
		public ICollection<SEMESTER> SemestersOffered { get; set; }

		// One-to-many self-referencing relationship
		public virtual ICollection<Course> Prerequisites { get; set; }
		public virtual ICollection<Class> Classes { get; set; }
		public virtual ICollection<Major> Majors { get; set; }
	}
}
