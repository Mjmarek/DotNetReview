using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_Inheritance_Exercise_2
{
    public class FrontEndSenior : Senior
    {
        public bool MiniLessonsAreComplete { get; set; } = false;
        public int CompletedMiniLessons { get; set; } = 0;

        public FrontEndSenior(
            int developerId,
            string developerName,
            LanguageType language) : base(developerId, developerName, language)
        {

        }
    }
}
