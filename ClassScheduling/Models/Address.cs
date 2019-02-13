using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClassScheduling.Models
{
	public class Address
	{
		//public Address(string addressID, string street, string city,
		//	string stateProvince, int zip, string phone)
		//{
		//	AddressID = addressID;
		//	Street = street;
		//	City = city;
		//	StateProvince = stateProvince;
		//	Zip = zip;
		//	Phone = phone;
		//}
		[Key]
		[ForeignKey("Student")]
		public string StudentID { get; set; }
		public string Street { get; set; }
		public string City { get; set; }
		[Display(Name = "State/Province")]
		public string StateProvince { get; set; }
		public int Zip { get; set; }
		[StringLength(15)]
		public string Phone { get; set; }

		public virtual Student Student { get; set; }
	}
}