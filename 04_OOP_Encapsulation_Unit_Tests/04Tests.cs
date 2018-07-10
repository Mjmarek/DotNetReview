using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04_OOP_Encapsulation_Exercise_1;
using _04_OOP_Encapsulation_Exercise_2;
using _04_OOP_Encapsulation_Exercise_3;
using _04_OOP_Encapsulation_Exercise_4;

namespace _04_OOP_Encapsulation_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        //Exercise 1 Unit Tests
        #region
        [TestMethod]
        [ExpectedException(typeof(Exception), "First name is invalid.")]
        public void NullFirstName_ShouldThrowException()
        {
            //Arrange
            var customer = new Customer(null, "Smith", 55);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Not a valid age.")]
        public void AgeTooHigh_ShouldThrowException()
        {
            //Arrange
            Customer customer1 = new Customer();

            //Act
            customer1.Age = 121;
        }
        #endregion

        //Exercise 2 Unit Tests
        #region
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Room dimensions do not meet specifications.")]
        public void CalculateRoomArea_ShouldThrowException()
        {
            //Arrange
            var room1 = new Room(); //instantiated with default constructor; did not use constructor with 3 parameters

            //Act
            room1.Width = 5; //properties manipulated individually
            room1.Length = 5;

            room1.CalculateRoomArea();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Room height is too large.")]
        public void RoomHeightTooSmall_ShouldThrowException()
        {
            //Arrange
            var room1 = new Room(15, 25, 21);
        }

        [DataTestMethod] //helps you get around testing private setters
        [DataRow(8, 8, 10)]
        [DataRow(15, 15, 11)]
        [DataRow(30, 30, 12)]
        public void ConstructorWorksWithMultipleParameters(double l, double w, double h)
        {
            //Act
            Room room = new Room(l, w, h);
            Console.WriteLine(room);
        }
        #endregion

        //Exercise 3 Unit Tests
        #region
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Age is too high.")]
        public void AgeIsTooHigh_ShouldThrowException()
        {
            //Act
            var driver = new YoungDriver("John Smith", 26);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Age is too low.")]
        public void AgeIsTooLow_ShouldThrowException()
        {
            //Act
            var driver = new YoungDriver("Jane Doe", 15);
        }

        [TestMethod]
        public void CalculateCost_ShouldReturnHighValue()
        {
            //Act
            var driver = new YoungDriver("Huck Finn", 17);

            //Arrange
            driver.CalculateInsuranceCost();
            var actual = driver.InsuranceCost;
            var expected = 228;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateCost_ShouldReturnMidValue()
        {
            //Act
            var driver = new YoungDriver("Tom Sawyer", 20);

            //Arrange
            driver.CalculateInsuranceCost();
            var actual = driver.InsuranceCost;
            var expected = 192;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateCost_ShouldReturnLowValue()
        {
            //Act
            var driver = new YoungDriver("Pippi Longstocking", 25);

            //Arrange
            driver.CalculateInsuranceCost();
            var actual = driver.InsuranceCost;
            var expected = 180;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion

        //Exercise 4 Unit Tests
        #region
        [TestMethod]
        public void CalculateDeveloperBalance_ShouldSucceed()
        {
            //Arrange
            var dev1 = new Developer(50, "John Doe");
            var course1 = new Course(151, "C# Deep Dive", 25m);
            var enrollment1 = new Enrollment(course1, dev1);
            var enrolledCourses = new List<Enrollment>();
            enrolledCourses.Add(enrollment1);

            //Act
            dev1.CalculateDeveloperBalance(enrolledCourses);
            var expected = 75m;
            var actual = dev1.Balance;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
