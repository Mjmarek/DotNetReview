using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_4
{
    public class EnrollmentRepository
    {
        private List<Enrollment> _enrollments = new List<Enrollment>();

        public void AddEnrollment(Enrollment enrollment)
        {
            _enrollments.Add(enrollment);
        }
    }
}
