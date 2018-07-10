using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06_Polymorphism_Demo_3.Contracts;

namespace _06_Polymorphism_Demo_3.Models
{
    public class Employee
    {
        private ISwipeable _swipeable;

        public Employee(ISwipeable swipeable)
        {
            _swipeable = swipeable; //exposes private field
        }

        public void SwipeCard()
        {
            Console.WriteLine("Swiping card now...");
            _swipeable.Swipe();
        }
    }
}
