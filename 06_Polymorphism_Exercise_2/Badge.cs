using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Exercise_2
{
    public class Badge
    {
        public int Level { get; set; }

        public Badge(int level)
        {
            Level = level;
        }

        public virtual string Access()
        {
            return "Check Access";
        }
    }
}
