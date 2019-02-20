using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ClassScheduling.Models;

namespace ClassScheduling.DataAccessLayer
{
	public class SchedulingContext : DbContext
	{
		public SchedulingContext() : base("SchedulingContext")
		{

		}

		public DbSet<Student> Students { get; set; }
		public DbSet<Address> Addresses { get; set; }
		//public DbSet<Major> Majors { get; set; }
		public DbSet<Enrollment> Enrollments { get; set; }
		//public DbSet<Course> Courses { get; set; }
		public DbSet<Class> Classes { get; set; }
		//public DbSet<Instructor> Instructors { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

/*			// many-to-many relationship between Course and Major tables
			// which essentially creates a CourseMajor table, the way we 
			// designed the database originally
			modelBuilder.Entity<Course>()
				.HasMany(c => c.Majors).WithMany(m => m.MajorCourses)
				.Map(t => t.MapLeftKey("CourseRefID")
				.MapRightKey("MajorRefID")
				.ToTable("CourseMajor"));

			// many-to-many "self-referencing" relationship between courses
			// and its pre- and post-requisites
			modelBuilder.Entity<CourseRequisite>()
				.HasRequired(c => c.Course)
				.WithMany(cp => cp.Prerequisites)
				.HasForeignKey(c => c.CourseID)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<CourseRequisite>()
				.HasRequired(c => c.PrereqCourse)
				.WithMany(cp => cp.Postrequisites)
				.HasForeignKey(c => c.PrereqCourseID);
*/
		}
	}
}