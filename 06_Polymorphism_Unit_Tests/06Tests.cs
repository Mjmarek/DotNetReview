using System;
using System.Security.Claims;
using _06_Polymorphism_Exercise_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _06_Polymorphism_Exercise_3;

namespace _06_Polymorphism_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        //Exercise #2
        #region
        [TestMethod]
        public void BadgeA_AccessLevel1_ShouldSucceed()
        {
            //Arrange
            var badge = new BadgeA(1);

            //Act
            var expected = "Access Granted";
            var actual = badge.Access();
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BadgeB_AccessLevel3_ShouldReturnAccessDenied()
        {
            //Arrange
            var badge = new BadgeB(3);

            //Act
            var expected = "Access Denied";
            var actual = badge.Access();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(1, "Access Denied")]
        [DataRow(2, "Access Granted")]
        [DataRow(3, "Access Denied")]
        public void BadgeB_VerifyAccess_ShouldSucceed(int level, string access)
        {
            //Act
            var badgeB = new BadgeB(level);
            Console.WriteLine(badgeB.Access());
            
            var expected = access;
            var actual = badgeB.Access();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion

        //Exercise #3
        #region
        [TestMethod]
        public void Claims_ElevatorMessage_ShouldSucceed()
        {
            //Arrange
            var claims = new Claims(504, "Amy Pond", 21, "You have a meeting today.");

            //Act
            var expected = "Good morning, Amy Pond. You have 21 claims to review today.";
            var actual = $"Good morning, {claims.EmployeeName}. You have {claims.ClaimsToDo} claims to review today.";
            Console.WriteLine(claims.Elevator());

            //Assert
            Assert.AreEqual(expected, actual);
        }

        #endregion
    }
}
