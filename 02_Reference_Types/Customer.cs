using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Reference_Types
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }

        public Customer(string firstName, string email, string phoneNumber, DateTime birthDate)
        {
            FirstName = firstName;
            Email = email;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
        }

        public int CalculateAge()
        {
            return (DateTime.Now.Year - BirthDate.Year);
        }
    }
}
