using System.Collections.Generic;

namespace _06_Polymorphism_Demo_2
{
    interface ITeacherService
    {
        bool Create(Teacher teacher);
        Teacher GetById(int teacherId);
        IEnumerable<Teacher> GetAll();
        bool Update(Teacher teacher);
        bool Delete(int teacherId);
    }
}