using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_Inheritance_Exercise_1
{
    public abstract class Outing //can't create instance of abstract class
    {
        public int NumberAttended { get; set; }
        public DateTime OutingDate { get; set; }
        public string Location { get; set; }
        public decimal TotalCost { get; set; }

        public Outing()
        {

        }

        public Outing(int numberAttended, DateTime outingDate, string location, decimal totalCost)
        {
            NumberAttended = numberAttended;
            OutingDate = outingDate;
            Location = location;
            TotalCost = totalCost;
        }

        //have to implement this method in non-abstract derived classes
        //abstract method must be contained in abstract class
        public abstract void CalculateCostPerPerson();
    }
}
