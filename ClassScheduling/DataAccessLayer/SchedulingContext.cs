﻿using System;
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
		public DbSet<Major> Majors { get; set; }
		public DbSet<Enrollment> Enrollments { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Class> Classes { get; set; }
		public DbSet<Instructor> Instructors { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


		}
	}
}