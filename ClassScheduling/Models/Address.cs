using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassScheduling.Models
{
	public class Address
	{
		public Address(string addressID, string street, string city,
			string stateProvince, int zip, string phone)
		{
			AddressID = addressID;
			Street = street;
			City = city;
			StateProvince = stateProvince;
			Zip = zip;
			Phone = phone;
		}
		public string AddressID { get; set; }
		public string Street { get; set; }
		public string City { get; set; }
		public string StateProvince { get; set; }
		public int Zip { get; set; }
		public string Phone { get; set; }
	}
}