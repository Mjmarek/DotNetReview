using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Exercise_2
{
    public class BadgeB : Badge
    {
        public BadgeB(int level) : base(level)
        {

        }

        public override string Access()
        {
            if (Level == 2)
                return "Access Granted";
            else
                return "Access Denied";
        }
    }
}
