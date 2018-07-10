using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_Inheritance_Exercise_2
{
    public class Junior : Developer
    {
        public bool OnlineTrainingIsComplete { get; set; } = false;

        public Junior(
            int developerId,
            string developerName,
            LanguageType language) : base(developerId, developerName, language)
        {
            
        }
    }
}
