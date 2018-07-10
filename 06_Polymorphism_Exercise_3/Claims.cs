using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Exercise_3
{
    public class Claims : Employee
    {
        public int ClaimsToDo { get; set; }
        
        public Claims(int employeeId, string employeeName, int claimsToDo, string calendarReminder)
            : base(employeeId, employeeName, calendarReminder)
        {
            ClaimsToDo = claimsToDo;
        }

        public override string Entrance()
        {
            return $"Good morning, {EmployeeName}. {CalendarReminder}";
        }

        public override string Elevator()
        {
            return $"Hello, {EmployeeName}. You have {ClaimsToDo} claims to review today.";
        }

        public override string Exit()
        {
            var claimsDoneToday = 5; //would have to pull this number from somewhere, not hard-coded
            var claimsCompleted = ClaimsToDo - claimsDoneToday;
            return $"Good bye, {EmployeeName}. You reviewed {claimsCompleted} claims today.";
        }
    }
}
