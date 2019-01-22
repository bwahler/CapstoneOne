using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneOne
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Welcome to the Pig Latin Translator");
                //Request input from user
                Console.WriteLine("Please enter a sentence to convert to Pig Latin:");
                string sentence = Console.ReadLine();
                //variable to defined for static method, then variable is printed out
                var language = PigLatin(sentence);
                Console.WriteLine(language);
                //While loop is used to continue run and the continue method is called
                run = Continue();
            }
        }

        public static string PigLatin(string sentence)
        {
            string vowels = "aeiou";
            List<string> newWord = new List<string>();

            foreach (string word in sentence.Split(' '))
            {
                string firstLetter = word.Substring(0, 1);
                string entireWord = word.Substring(1, word.Length - 1);
                int letter = vowels.IndexOf(firstLetter);

                if(letter == -1)
                {
                    newWord.Add(entireWord + firstLetter + "ay");
                }
                else
                {
                    newWord.Add(word + "way");
                }
            }
            return string.Join(" ", newWord);
        }

        public static bool Continue()
        {
            //User continue validates the input and will only continue if a Y is entered and only exit if an N is entered
            Console.WriteLine("Would you like to translate another line? (y/n)");
            string userContinue = Console.ReadLine().ToLower();
            bool execute;
            if (userContinue == "y")
            {
                 execute = true;
            }
            else if(userContinue == "n")
            {
                 execute = false;
            }
            else
            {
                Console.WriteLine("Invalid entry. Please try again:");
                execute = Continue();
            }
            return execute;
        }
    }
}
