using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Demo_1
{
    class ManagerService : IPerson<Manager>
    {
        public bool Create(Manager model)
        {
            model.ManagerID = 1;

            return true;
        }

        public bool Deleted(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Manager> GetAll()
        {
            throw new NotImplementedException();
        }

        public Manager GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Manager model)
        {
            throw new NotImplementedException();
        }
    }
}
