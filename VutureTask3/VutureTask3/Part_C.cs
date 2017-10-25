using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VutureTask3
{
    //Create a way to censor a single word palindrome in a text.
    public class Part_C
    {
        public static void DoWork()
        {
           
            Console.WriteLine("Enter a text");
            string myText = Console.ReadLine();

            char[] dividingChars = { ' ', ',', '.', ':', '\t', '"' };
            string[] myTextArray = myText.Split(dividingChars);

            string message;

            for( int i=0; i<myTextArray.Length; i++)
            {
                if (IsPalindrome(myTextArray[i]))
                {
                    string[] newArray = myTextArray.Select(x => x.Replace(myTextArray[i], "$$$$")).ToArray();
                    message = ConvertArrayToString(newArray);
    
                }
                else
                {
                    message = ConvertArrayToString(myTextArray);
                   
                }
  
            
            }

           Console.WriteLine("{0}", message);
          

        }

       
        public static bool IsPalindrome(string word)
        {
            //char[] trimChars = { ' ', '.', ':', '"' };
            string newWord = word.ToLower();

            char[] array = newWord.ToCharArray();

            Array.Reverse(array);
            string backwards = new string(array);

            return backwards == newWord;
        }



        public static string ConvertArrayToString(string[] array)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append(' ');
            }
            return builder.ToString();
        }



    }
}
