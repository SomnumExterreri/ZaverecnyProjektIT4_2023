using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaverecnaPrace
{
    internal class Employee
    {
        public Employee(int personalNumber, string firstName, string lastName, DateTime birthDate, string email, string phone)
        {
            PersonalNumber = personalNumber;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Email = email;
            Phone = phone;
        }

        public int PersonalNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
