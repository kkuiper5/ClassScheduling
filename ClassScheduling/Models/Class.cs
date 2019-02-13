using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClassScheduling.Models
{
	public enum FORMAT { inSeat, online };

	public class Class
	{
		public string ID { get; set; }
		public string Room { get; set; }
		[DataType(DataType.Time)]
		[DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
		public DateTime StartTime { get; set; }
		[DataType(DataType.Time)]
		[DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
		public DateTime EndTime { get; set; }
		public string Days { get; set; }
		public FORMAT Format { get; set; }
		public SEMESTER Semester { get; set; }
		public string CourseID { get; set; }
		public string InstructorID { get; set; }

		public virtual Course Course { get; set; }
		public virtual Instructor Instructor { get; set; }
		public virtual ICollection<Enrollment> Schedules { get; set; }
	}
}