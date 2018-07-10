using System.Collections.Generic;

namespace _06_Polymorphism_Demo_2
{
    //interfaces are usually used just for methods
    //similar to repository -> used for persistence
    //CRUD repository pattern
    interface IStudentService
    {
        bool Create(Student student);
        Student GetById(int studentId); //take id, query db, return object that corresponds to id
        IEnumerable<Student> GetAll();
        bool Update(Student student);
        bool Delete(int studentId);
    }
}