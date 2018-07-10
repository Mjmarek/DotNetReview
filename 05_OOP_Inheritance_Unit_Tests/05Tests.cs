using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _05_OOP_Inheritance_Exercise_2;

namespace _05_OOP_Inheritance_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        //Exercise 2
        #region
        [TestMethod]
        public void CreateFrontEndJuniorDeveloper_ShouldSucceed()
        {
            //Arrange
            var jrDev1 = new FrontEndJunior(23, "Jane Doe", LanguageType.Csharp);
            
            //Act
            var expected = false;
            var actual = jrDev1.OopCourseIsComplete;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateFrontEndSeniorDeveloper_ShouldSucceed()
        {
            //Arrange
            var srDev1 = new FrontEndSenior(12, "John Smith", LanguageType.Angular);

            //Act
            var expected = 0;
            var actual = srDev1.CompletedMiniLessons;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
