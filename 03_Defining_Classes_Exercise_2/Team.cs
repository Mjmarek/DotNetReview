using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_2
{
    public class Team
    {
        public Developer Developer { get; set; }

        //"Object not set to instance of constructor" means object hasn't been initialized yet
        List<Developer> Developers = new List<Developer>();
        
        public void AddDev(Developer Developer)
        {
            Developers.Add(Developer);
        }
    }
}
