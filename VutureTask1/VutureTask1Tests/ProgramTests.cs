using Microsoft.VisualStudio.TestTools.UnitTesting;
using VutureTask1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VutureTask1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            //Arrange
            string myInput = "I have some cheese";
            char myChar = 'e';



            //Act
            char[] myArray = myInput.ToCharArray();
            int count = 0;
            foreach (char item in myArray)
            {
                count++;
            }



            //Assert
            Assert.AreEqual();
        }
    }
}