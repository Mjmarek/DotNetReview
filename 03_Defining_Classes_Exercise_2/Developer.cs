using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_2
{
    public class Developer
    {
        public int EmployeeId { get; set; } //public Guid Id { get; } = Guid.NewGuid();
        public string LastName { get; set; }
        public bool HasPluralSight { get; set; }

        public Developer(int employeeId, string lastName, bool hasPluralSight)
        {
            EmployeeId = employeeId;
            LastName = lastName;
            HasPluralSight = hasPluralSight;
        }

        public override string ToString()
        {
            return $"{EmployeeId} {LastName} {HasPluralSight}";
        }
    }
}
