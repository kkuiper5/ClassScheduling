﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassScheduling.Models
{
	public enum SEMESTER { F18, W19, SS19, F19, W20, SS20, F20, W21, SS21 };

	public class Schedule
	{
		public Schedule(string scheduleID, string studentID, SEMESTER semester, List<Class> classes)
		{
			ScheduleID = scheduleID;
			StudentID = studentID;
			Semester = semester;
			Classes = classes;
		}

		public string ScheduleID { get; set; }
		public string StudentID { get; set; }
		public SEMESTER Semester { get; set; }
		public List<Class> Classes { get; set; }
	}
}