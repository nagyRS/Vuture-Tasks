using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VutureTask2
{
    //Create a function which decides if a string is a palindrome.
   public  class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter your word");

            string text = Console.ReadLine();

            string message =Convert.ToString(IsPalindrome(text));  // returns the answer true or false

            Console.WriteLine("{0}", message);


        }


        public static bool IsPalindrome(string word)
        {
            char[] trimChars = { ' ', '.', ':' };

            string newWord = word.Trim(trimChars).ToLower();

            char[] array = newWord.ToCharArray();

            Array.Reverse(array);

            string backwards = new string(array);

            return backwards == newWord;

        }
    }
}
