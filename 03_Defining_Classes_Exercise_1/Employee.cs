using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_1
{
    public class Employee
    {
        public int EmployeeId { get; set; } //probably should be Guid (not sure how to generate one programatically)
        public string LastName { get; set; }
        public int Age { get; set; }
        public int YearsEmployed { get; set; }

        //can overload methods and constructors
        //example here of overloading constructor:
        public Employee()
        {

        }

        public Employee(int employeeId, string lastName, int age, int yearsEmployed)
        {
            EmployeeId = employeeId;
            LastName = lastName;
            Age = age;
            YearsEmployed = yearsEmployed;
        }
    }
}
