using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VutureTask1;

namespace TestTask1
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void CountTest()
        {
            // Arrange
            Program myObject = new Program();

            string myString = "I have some cheese";
            char[] myArray = myString.ToCharArray();

            char myChar = 'e';


            //Act

            int myCount = Program.Count(myArray, myChar);


            //Assert

            Assert.AreEqual(5, myCount);
        }

       
    }
}
