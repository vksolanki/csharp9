using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb
{

    public class Department
    {
        public string Name { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }
        public Department Department { get; set; }
        public Address Address { get; set; }
    }

    public class StudentFactory
    {
        public static Student GetStudent()
        {
            Student student = new Student()
            {
                Name = "Smith",
                Address = new Address()
                {
                    City = "NY",
                    Street = "Street"
                },
                Department = new Department()
                {
                    Name = "IT"
                }
            };

            return student;
        }
    }
}
