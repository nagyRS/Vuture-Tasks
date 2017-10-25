using Microsoft.VisualStudio.TestTools.UnitTesting;
using VutureTask3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VutureTask3.Tests
{
    [TestClass()]
    public class Part_ATests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            //Arrange

            Part_A myClass = new Part_A();

            string word1 = "cat";
            string word2 = "dog";
            string word3 = "large";

            string myText = "I have a cat named Meow and a dog name Woof. I love the dog a lot. He is larger than a small horse.";

            char[] dividingChars = { ' ', ',', '.', ':', '\t' };

            string[] myTextArray = myText.Split(dividingChars);


            //Act
            int expected1 = 1;
            int expected2 = 2;
            int expected3 = 1;

            int actual1 = Part_A.Calculate(word1, myTextArray);
            int actual2 = Part_A.Calculate(word2, myTextArray);
            int actual3 = Part_A.Calculate(word3, myTextArray);


            //Assert

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
    }
}