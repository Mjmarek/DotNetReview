using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_4
{
    public class DeveloperRepository
    {
        private List<Developer> _developers = new List<Developer>();

        public void AddDeveloper(Developer developer)
        {
            _developers.Add(developer);
        }
    }
}
