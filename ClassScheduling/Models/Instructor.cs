using System;
namespace ClassScheduling.Models
{
    public class Instructor
    {
        public Instructor()
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string InstructorID { get; set; }
            public string EmailAddress { get; set; }
            public string Street { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public int Zip { get; set; }
            public string Phone { get; set; }

            public Instructor(string first, string last, string id, string email, string street,
                string city, string state, int zip, string phone)
            {
                FirstName = first;
                LastName = last;
                InstructorID = id;
                EmailAddress = email;
                Street = street;
                City = city;
                State = state;
                Zip = zip;
                Phone = phone;
            }
        }
    }
}
