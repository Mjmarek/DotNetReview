using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_4
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public decimal CourseCost { get; set; }

        public Course(int courseId, string courseName, decimal courseCost)
        {
            CourseId = courseId;
            CourseName = courseName;
            CourseCost = courseCost;
        }
    }
}