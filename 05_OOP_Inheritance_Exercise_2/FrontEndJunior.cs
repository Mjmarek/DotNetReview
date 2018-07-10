using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_Inheritance_Exercise_2
{
    public class FrontEndJunior : Junior
    {
        public bool OopCourseIsComplete { get; set; } = false;

        public FrontEndJunior(
            int developerId,
            string developerName,
            LanguageType language) : base(developerId, developerName, language)
        {
            
        }
    }
}