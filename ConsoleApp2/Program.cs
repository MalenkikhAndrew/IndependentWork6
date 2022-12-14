using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static bool IsPalindrome(string phrase)
        {
            StringBuilder cleanPhraseBuilder = new StringBuilder();

            foreach (char c in phrase)
            {
                if (char.IsLetterOrDigit(c)) cleanPhraseBuilder.Append(c);
            }

            string forwards = cleanPhraseBuilder.ToString().ToLower();
            char[] characters = forwards.ToCharArray();
            Array.Reverse(characters);
            string backwards = new string(characters);
            return forwards == backwards;
            Console.ReadKey();
        }
    }
}
