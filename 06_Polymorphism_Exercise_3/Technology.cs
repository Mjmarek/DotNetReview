using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Exercise_3
{
    public class Technology : Employee
    {
        public int LinesOfCode  { get; set; }
        public string GitHubUser { get; set; }
        public string StackOverflowUser { get; set; }

        public Technology(int employeeId, string employeeName, string calendarReminder, int linesOfCode,
            string gitHubUser, string stackOverflowUser) : base(employeeId, employeeName, calendarReminder)
        {
            LinesOfCode = linesOfCode;
            GitHubUser = gitHubUser;
            StackOverflowUser = stackOverflowUser;
        }

        public override string Entrance()
        {
            return $"Good morning, {EmployeeName}. {CalendarReminder}";
        }

        public override string Elevator()
        {
            return $"{StackOverflowUser}, you have a response to your Stack Overflow question.";
        }

        public override string Exit()
        {
            return $"Good bye, {EmployeeName}. You pushed {LinesOfCode} to your repo today.";
        }

    }
}
