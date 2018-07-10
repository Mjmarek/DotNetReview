using System.Collections.Generic;
using System.Data;

namespace _06_Polymorphism_Demo_1
{
    //interface-based polymorphism with generics

    //interface does not need to be public because all classes that will implement are in same assembly
    interface IPerson<T> //generics
    {
        bool Create(T model); //"yes" - person was created & saved in db; that's why it returns bool
        T GetById(int id);
        IEnumerable<T> GetAll();
        bool Update(T model);
        bool Deleted(int id);
    }
}