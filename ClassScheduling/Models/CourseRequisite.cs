using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClassScheduling.Models
{
	public class CourseRequisite
	{
		public int CourseID { get; set; }
		public int PrereqCourseID { get; set; }

		public virtual Course Course { get; set; }
		public virtual Course PrereqCourse { get; set; }
	}
}