using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Exercise_3
{
    public class Sales : Employee
    {
        public decimal TeamGoal { get; set; } //add all personal goals together
        public decimal PersonalGoal { get; set; }
        public decimal DailySales { get; set; }

        public Sales(int employeeId, string employeeName, string calendarReminder, decimal personalGoal) 
            : base (employeeId, employeeName, calendarReminder)
        {
            PersonalGoal = personalGoal;
        }

        public override string Entrance()
        {
            return $"Good morning, {EmployeeName}. Your sales goal for this month is ${PersonalGoal}.";
        }

        public override string Elevator()
        {
            return $"Remember, {EmployeeName}: Your team's goal for the month is {TeamGoal}.";
        }

        public override string Exit()
        {
            return $"Good bye, {EmployeeName}. You made ${DailySales} in sales today.";
        }
    }
}
