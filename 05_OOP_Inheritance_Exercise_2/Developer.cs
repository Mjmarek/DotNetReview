using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_Inheritance_Exercise_2
{
    public class Developer
    {
        public int DeveloperId { get; set; }
        public string DeveloperName { get; set; }
        public bool OrientationIsComplete { get; set; } = false;
        public bool MonthlyPluralSightIsComplete { get; set; } = false;
        public int MonthlyPluralSightHours { get; set; } = 0;
        public LanguageType Language { get; set; }
        public AppType? App { get; set; }

        public Developer(int developerId, string developerName, LanguageType language)
        {
            DeveloperId = developerId;
            DeveloperName = developerName;
            Language = language;
        }
    }

    public enum LanguageType
    {
        Csharp = 1,
        Angular = 2,
        React = 3
    }
    
    public enum AppType
    {
        DotNet = 1,
        DotNetCore = 2,
        AngularJs = 3,
        Angular6 = 4,
        Flux = 5,
        Redux = 6
    }

    //TODO - link languauge type to app type? so you wouldn't have a c# person with flux? IDK how you'd even do this?
    //TODO - some way to track skill rating?
}
