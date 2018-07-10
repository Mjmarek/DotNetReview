using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_1
{
    public class Customer
    {
        private string _firstName;//backing field; holds value
        private string _lastName;
        private int _age;

        public string FirstName
        {
            get { return _firstName; } //get => _firstName (expression bodied member)
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("First name is invalid.");
                }
                else
                {
                    _firstName = value.Trim();
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Last name is invalid.");
                }
                else
                {
                    _lastName = value;
                }
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentException("Not a valid age.");
                }
                _age = value; //else is not necessary
            }
        }

        //separate constructors for testing purposes
        public Customer() { }

        public Customer(string firstName)
        {
            FirstName = firstName;
        }

        public Customer(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString() =>
            string.Format($"First Name: {_firstName}, Last Name: {_lastName}, Age: {_age}");
    }
}
