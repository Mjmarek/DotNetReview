using System.Collections.Generic;

namespace _06_Polymorphism_Demo_2
{
    interface IContractorService
    {
        bool Create(Contractor contractor);
        Contractor GetIdBy(int ContractorId);
        IEnumerable<Contractor> GetAll();
        bool Update(Contractor contractor);
        bool Delete(Contractor contractor);
    }
}