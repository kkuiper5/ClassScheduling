using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassScheduling.Models
{
	public enum SEMESTER { F18, W19, SS19, F19, W20, SS20, F20, W21, SS21 };
	public enum GRADE { A, B, C, D, F };

	public class Enrollment
	{
		public string ID { get; set; }
		public string StudentID { get; set; }
		public string ClassID { get; set; }
		public GRADE Grade { get; set; }
		
		public virtual Student Student { get; set; }
		public virtual Class Class { get; set; }
	}
}