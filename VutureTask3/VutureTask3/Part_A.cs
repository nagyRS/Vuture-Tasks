using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VutureTask3
{
    //Create a function which counts the number of occurrences of words from a "censored words list" in a text.
    public class Part_A
    {
        public static void DoWork1()
        {
            char[] trimChars = { 's', 'r' };

            Console.WriteLine("Enter the first word");
            string word1 = Console.ReadLine();

            Console.WriteLine("\nEnter the second word");
            string word2 = Console.ReadLine();

            Console.WriteLine("\nEnter the third word");
            string word3 = Console.ReadLine();

            Console.WriteLine("\nEnter the text");
            string myText = Console.ReadLine();
     
            char[] dividingChars = { ' ', ',', '.', ':', '\t' };

            string[] myTextArray = myText.Split(dividingChars);



            int countWord1 = Calculate(word1, myTextArray);
            int countWord2 = Calculate(word2, myTextArray);
            int countWord3 = Calculate(word3, myTextArray);


            int total = countWord1 + countWord2 + countWord3;

            Console.WriteLine("{0}  :  {1}", word1, countWord1);
            Console.WriteLine("{0}  :  {1}", word2, countWord2);
            Console.WriteLine("{0}  :  {1}", word3, countWord3);

            Console.WriteLine("Total: {0}", total);

        }

        public static int Calculate(string word, string[] array)
        {
            int countWord = 0;
            char[] trimChars = { 's', 'r' };

            foreach (string item in array)
            {
                if (item.Trim(trimChars).ToLower() == word)
                {
                    countWord++;
                }
            }
            return countWord;

        }

    }
}
