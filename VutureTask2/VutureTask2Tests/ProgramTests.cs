using Microsoft.VisualStudio.TestTools.UnitTesting;
using VutureTask2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VutureTask2.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            //Arrange
            Program myTest = new Program();



            //Act
            bool actual = Program.IsPalindrome("eve");

            bool expected = true;


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}