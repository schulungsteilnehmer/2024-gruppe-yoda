using System;
using System.Text.RegularExpressions;

namespace Zeugnismodell
{
    public class Name
    {
        public string name;

        public static string FormatName()
        {
            Console.WriteLine("Bitte geben Sie Ihren Namen ein: ");
            string input = Console.ReadLine();

            if (IsValidName(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Der eingegebene Name ist falsch.");
                return FormatName(); 
            }
        }

        private static bool IsValidName(string name)
        {
            string pattern = @"^[a-zA-ZäöüÄÖÜß\s-]+$";
            return Regex.IsMatch(name, pattern);
        }
    }
}