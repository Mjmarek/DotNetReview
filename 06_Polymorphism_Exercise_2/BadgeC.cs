using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Exercise_2
{
    public class BadgeC : Badge
    {
        public BadgeC(int level) : base(level)
        {

        }

        public override string Access()
        {
            if (Level == 3)
                return "Access Granted";
            else
                return "Access Denied";
        }
    }
}
