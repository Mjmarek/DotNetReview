using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_3
{
    public class YoungDriver
    {
        public string Name { get; set; }
        public double InsuranceCost { get; set; }
        private int _age;

        public int Age //should be calculated based on currrent date
        {
            get { return _age; }
            set
            {
                if (value < 16)
                {
                    throw new ArgumentException("Age is too low.");
                }
                else if (value > 25)
                {
                    throw new ArgumentException("Age is too high.");
                }
                else
                {
                    _age= value;
                }
            } 
        }

        public YoungDriver(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void CalculateInsuranceCost()
        {
            if (Age >= 16 && Age <= 19)
            {
                InsuranceCost = (120 * .9) + 120;
            }
            else if (Age >= 20 && Age <= 22)
            {
                InsuranceCost = (120 * .6) + 120;
            }
            else if (Age >= 13 && Age <= 25)
            {
                InsuranceCost = (120 * .5) + 120;
            }
            else //not sure if this is necessary, since age is set before this method is called
            {
                throw new ArgumentException("Age is out of range for young drivers.");
            }
        }
    }
}
