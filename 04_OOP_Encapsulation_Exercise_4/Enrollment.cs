using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_4
{
    public class Enrollment
    {
        public Course Course { get; set; }
        public Developer Developer { get; set; }

        public Enrollment(Course course, Developer developer)
        {
            Course = course;
            Developer = developer;
        }
    }
}
