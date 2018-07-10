using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_Inheritance_Exercise_2
{
    public class Senior : Developer
    {
        public Senior(
            int developerId,
            string developerName,
            LanguageType language) : base(developerId, developerName, language)
        {
           
        }
    }
}
