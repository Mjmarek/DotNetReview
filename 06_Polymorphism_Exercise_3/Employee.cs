using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Exercise_3
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string CalendarReminder { get; set; }

        public Employee(int employeeId, string employeeName, string calendarReminder)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            CalendarReminder = calendarReminder;
        }

        public virtual string Entrance()
        {
            return $"Hello, {EmployeeName}.";
        }

        public virtual string Elevator()
        {
            return $"Have a good day, {EmployeeName}.";
        }

        public virtual string Exit()
        {
            return $"Good bye, {EmployeeName}.";
        }
    }
}
