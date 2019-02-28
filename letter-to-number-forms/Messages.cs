using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letter_to_number_forms
{
    class Messages
    {
        public static string Greeting = "Welcome. Please enter a word to convert to a percentage:";

        public static string Instruction = "Type in a word";

        public static string StringBreak(string word)
        {
            return $"\nBreakup of the word {word} is \n{Conversions.StringBreak(word)}\n";
        }

        public static string StringTotal(string word)
        {
            return $"{word} has a score of {Conversions.StringTotal(word)} %";
        }
    }
}
