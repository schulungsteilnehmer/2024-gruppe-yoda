using System.Text.RegularExpressions;

namespace Zeugnismodell;

public class Name
{
    public static void FormatName()
    {
        Console.WriteLine(
            "Bitte geben Sie Ihren Namen ein: ");
        string input = Console.ReadLine();

        if (IsValidName(input))
        {
        }
        else
        {
            Console.WriteLine("Der eingegebene Name ist falsch.");
        }

        static bool IsValidName(string name)
        {
            string pattern = @"^[a-zA-ZäöüÄÖÜß\s-]+$";
            return Regex.IsMatch(name, pattern);
        }
    }
}