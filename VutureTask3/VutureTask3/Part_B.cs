using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VutureTask3
{
    //Create a way to censor words featured in the "censored words list" that appear in the text.
    public class Part_B
    {
        public static void DoWork()
        {
            Console.WriteLine("Enter the first word");
            string word1 = Console.ReadLine();

            Console.WriteLine("\nEnter the second word");
            string word2 = Console.ReadLine();


            Console.WriteLine("\nEnter the text");
            string myText = Console.ReadLine();

            char[] dividingChars = { ' ', ',', '.', ':', '\t' };

            string[] myTextArray = myText.Split(dividingChars);



            string[] firstCheck = Censor(word1, myTextArray);
            string[] newText = Censor(word2, firstCheck);


            string message = ConvertArrayToString(newText);

            Console.WriteLine(message);

        }



        public static string[] Censor(string word, string[] array)
        {
            string[] newArray = array.Select(x => x.Replace(word, "$$$$")).ToArray();
            return newArray;
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
