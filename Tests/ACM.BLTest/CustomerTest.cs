using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            var customer = new Customer {FirstName = "Bogdan", LastName = "Asaftei" };
            string expected = "Asaftei, Bogdan";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            var customer = new Customer {LastName = "Asaftei" };
            string expected = "Asaftei";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            var customer = new Customer { FirstName = "Bogdan" };
            string expected = "Bogdan";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Andrei";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Bogdan";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Lucian";
            Customer.InstanceCount += 1;

            // Act
            
            // Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //arrange
            var customer = new Customer()
            {
                LastName = "Asaftei",
                EmailAddress = "bogasa@gmail.com"
            };
            var expect = true;
            //act
            var actual = customer.Validate();
            //assert
            Assert.AreEqual(expect, actual);
        }
    }
}
