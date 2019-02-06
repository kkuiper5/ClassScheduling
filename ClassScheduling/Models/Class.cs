using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassScheduling.Models
{
	public enum FORMAT { inSeat, online };

	public class Class
	{
		public Class(string classID, Course course, string room,
			Instructor instructor, DateTime startTime, DateTime endTime,
			string days, FORMAT format, SEMESTER semester)
		{
			ClassID = classID;
			Course = course;
			Room = room;
			Instructor = instructor;
			StartTime = startTime;
			EndTime = endTime;
			Days = days;
			Format = format;
			Semester = semester;
		}

		public string ClassID { get; set; }
		public Course Course { get; set; }
		public string Room { get; set; }
		public Instructor Instructor { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public string Days { get; set; }
		public FORMAT Format { get; set; }
		public SEMESTER Semester { get; set; }
	}
}