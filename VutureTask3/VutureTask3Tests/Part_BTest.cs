using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VutureTask3;

namespace VutureTask3Tests
{
    [TestClass()]
    class Part_BTest
    {
        [TestMethod]

        public void CensorTest()
        {

            //Arrange

            string testInput = "I have a cat";
            char[] dividingChars = { ' ', ',', '.', ':', '\t' };
            string[] testInputArray = testInput.Split(dividingChars);

            string testWord = "cat";

            //Act
            string[] expected = { "I", "have", "a", "$$$$" };

            string[] actual = Part_B.Censor(testWord, testInputArray);


            //Assert
            Assert.AreEqual(expected, actual);

        }

        public void ConvertArrayToStringTest()
        {
            //Arrange

            string[] myArray = { "I", "have", "a", "cat" };
            string expected = "I have a cat";

            //Act
            string actual = Part_B.ConvertArrayToString(myArray);


            //Assert
            Assert.AreEqual(expected, actual);


        }
    }
}
