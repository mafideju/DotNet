using System;
using CMS.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CMS.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Bilbo Baggins";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameTestInvalid()
        {
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";

            string expected = "Bilbo";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateTestValid()
        {
            Customer customer = new Customer();
            customer.LastName = "Baggins";
            customer.EmailAddress = "baggins@hobbits.us";

            bool expected = true;
            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateTestMissingParts()
        {
            Customer customer = new Customer();
            customer.EmailAddress = "baggins@hobbits.us";

            bool expected = false;
            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
