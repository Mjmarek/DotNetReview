using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _02_Reference_Types;

namespace _02_Reference_Types_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateCustomerClass_ShouldSucceed()
        {
            //Arrange
            Customer customer = new Customer("Monica", "email@email.com", "123-456-7890", new DateTime(1980, 4, 25));

            //Act
            string expected = "Monica";
            Console.WriteLine(expected);

            var actual = customer.FirstName;
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateAge_ShouldSucceed()
        {
            //Arrange
            Customer customer = new Customer("Monica", "email@email.com", "123-456-7890", new DateTime(1980, 4, 25));

            //Act
            var actual = customer.CalculateAge();
            int expected = 38;
            Console.WriteLine(expected);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
