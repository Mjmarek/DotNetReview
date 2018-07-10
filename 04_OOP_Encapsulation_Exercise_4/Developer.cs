using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_4
{
    public class Developer
    {
        public int DeveloperId { get; set; }
        public string DeveloperName { get; set; }
        public decimal Balance { get; set; } = 100;

        public Developer(int developerId, string developerName)
        {
            DeveloperId = developerId;
            DeveloperName = developerName;
        }

        public void CalculateDeveloperBalance(List<Enrollment> enrolledCourses)
        {
            decimal totalCourseCost = 0;
            foreach (var enrolledCourse in enrolledCourses)
            {
                totalCourseCost += enrolledCourse.Course.CourseCost;
            }
            Balance = Balance - totalCourseCost;
        }
    }
}
