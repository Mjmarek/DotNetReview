using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Demo_2
{
    class TeacherService : ITeacherService
    {
        public bool Create(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int teacherId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Teacher> GetAll()
        {
            throw new NotImplementedException();
        }

        public Teacher GetById(int teacherId)
        {
            throw new NotImplementedException();
        }

        public bool Update(Teacher teacher)
        {
            throw new NotImplementedException();
        }
    }
}
