using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a function which counts the number of occurrences of a given letter in a string.

namespace VutureTask1
{
   public class Program
    {

       public static void Main(string[] args)
        {
            Console.WriteLine("Enter a text.");
            string myText = Console.ReadLine();

            char[] myArray = myText.ToCharArray();


            Console.WriteLine("Enter the character you want to count");
            char myChar = Convert.ToChar(Console.ReadLine().ToLower());


            int myCount = Count(myArray, myChar);

            Console.WriteLine("The result is {0}", myCount);


        }
     

        public static int Count(char[] myArray, char myChar)
        {

            int count = 0;

            foreach (char item in myArray)
            {
                if (item == myChar)
                {
                    count++;
                }
            }

            return count;
        }

     



    }
}
