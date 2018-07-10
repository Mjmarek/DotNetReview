using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Exercise_2
{
    public class BadgeA : Badge
    {
        public BadgeA(int level) : base(level)
        {

        }

        public override string Access()
        {
            if (Level == 1)
                return "Access Granted";
            else
                return "Access Denied";
        }
    }
}
