using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_Inheritance_Exercise_1
{
    public abstract class Competition : Outing
    {
        //can't call a method on something you can't instantiate
        //passes abstract method down the line until there's a non-abstract class
    }
}
