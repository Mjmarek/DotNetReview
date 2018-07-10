using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_4
{
    public class CourseRepository
    {
        private List<Course> _courses = new List<Course>();

        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }
    }
}
