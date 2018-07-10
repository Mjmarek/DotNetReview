using System.Collections.Generic;
using System.Security.Principal;

namespace _06_Polymorphism_Demo_2
{
    interface IManagerService
    {
        bool Create(Manager manager);
        Manager GetById(int managerId);
        IEnumerable<Manager> GetAll();
        bool Update(Manager manager);
        bool Delete(int managerId);
    }
}