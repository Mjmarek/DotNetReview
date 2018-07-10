using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_4
{
    public class Member
    {
        public string LastName { get; set; }
        public decimal TotalSales { get; set; }

        public Member(string lastName, decimal totalSales)
        {
            LastName = lastName;
            TotalSales = totalSales;
        }
    }
}
