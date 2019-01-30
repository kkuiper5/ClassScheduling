using System;
namespace ClassScheduling.Models
{
    public class Student
    {
        public Student()
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string StudentID { get; set; }
            public string EmailAddress { get; set; }
            public string Street { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public int Zip { get; set; }
            public string Phone { get; set; }

            public Student(string first, string last, string id, string email, string street,
                string city, string state, int zip, string phone) {
                FirstName = first;
                LastName = last;
                StudentID = id;
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
