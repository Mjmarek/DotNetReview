using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _06_Polymorphism_Demo_3.Models;
using _06_Polymorphism_Demo_3.Services;

namespace _06_Polymorphism_Unit_Tests
{
    [TestClass]
    public class UnitTest2
    {
        private Employee _employeeElevator;

        [TestMethod]
        public void Employee_ElevatorSwipe_ShouldPrintToConsole()
        {
            //Arrange
            _employeeElevator = new Employee(new ElevatorService());

            //Act
            _employeeElevator.SwipeCard();
        }
    }
}
