using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_Classes_Exercise_1;
using _03_Defining_Classes_Exercise_2;
using _03_Defining_Classes_Exercise_3;
using _03_Defining_Classes_Exercise_4;

namespace _03_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        //private variable
        //private Employee _employee; //global variable inside the test class
        //private List<Developer> _devs;

        //[TestInitialize]
        //public void Arrange()
        //{
        //    //Arrange
        //    _employee = new Employee();

        //    _employee.EmployeeId = 10345;
        //    _employee.LastName = "Wood";
        //    _employee.Age = 32;
        //    _employee.YearsEmployed = 2;
        //}

        //[TestMethod]
        //public void CreateEmployee_ShouldSucceed()
        //{
        //    //Arrange
        //    Employee employee = new Employee(12345, "Smith", 45, 10);

        //    //Act
        //    int expected = 10;
        //    Console.WriteLine(expected);

        //    var actual = employee.YearsEmployed;

        //    //Assert
        //    Assert.AreEqual(expected, actual);

        //    //Guid g = Guid.NewGuid(); - use this to create & test Guid
        //}

        //[TestMethod]
        //public void CreateEmployeeUsingTestInitializer_ShouldSucceed()
        //{
        //    //Arrange
            
        //    //Act
        //    string expected = "Wood";
        //    Console.WriteLine(expected);

        //    var actual = _employee.LastName;

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void AddDeveloperToList_ShouldSucceed()
        //{
        //    //not currently testing AddDev() from Team.cs
            
        //    //Arrange
        //    _devs = new List<Developer>();

        //    Developer dev1 = new Developer(54, "Doe", true);
        //    Developer dev2 = new Developer(23, "Smith", false);
        //    Developer dev3 = new Developer(36, "Williams", false);
            
        //    //Act
        //    _devs.Add(dev1);
        //    _devs.Add(dev2);
        //    _devs.Add(dev3);

        //    var expected = 3;
        //    var actual = _devs.Count;
            
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        
        //private Customer _customer;
        //private CustomerRepository _customerRepository;

        //[TestInitialize]
        //public void Arrange()
        //{
        //    _customer = new Customer(1, "Bon Jovi", 55, 40);
        //    _customerRepository = new CustomerRepository();
        //}

        //[TestMethod]
        //public void CustomerEmail_ReturnString()
        //{
        //    //Act
        //    var actual = _customerRepository.EmailCustomer(_customer);
        //    var expected = "You're a beast.";

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}

        private Member _member1;
        private Member _member2;
        private MemberRepository _memberRepository;

        [TestMethod]
        public void CalculateTotalSales_ShouldReturnTeamSales()
        {
            //Arrange
            _member1 = new Member("Smith", 100);
            _member2 = new Member("Williams", 200);
            _memberRepository = new MemberRepository();

            //Act
            _memberRepository.AddMemberToList(_member1);
            _memberRepository.AddMemberToList(_member2);

            var actual = _memberRepository.CalculateTeamSales();

            var expected = 300m;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}