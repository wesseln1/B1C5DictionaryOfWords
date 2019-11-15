using System;
using System.Collections.Generic;

namespace DictionaryOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Fabulous", "The feeling of students when they are learning Python");
            wordsAndDefinitions.Add("Frustration", "The feeling of students when they are learning Javascript");
            wordsAndDefinitions.Add("Amazed", "The feeling of students when they are learning React");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            // foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            // {
            //     if
            // }

            Console.WriteLine(wordsAndDefinitions["Awesome"]);
            Console.WriteLine(wordsAndDefinitions["Amazed"]);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            };
        }
    }
}