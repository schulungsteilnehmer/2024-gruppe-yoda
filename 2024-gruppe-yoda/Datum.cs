using System.Globalization;

namespace Zeugnismodell;

public class Datum
{
    public static void Geburtsdatum()
    {
        Console.WriteLine("Bitte geben Sie Ihr Geburtsdatum ein (DD,MM,YY):");

        string input = Console.ReadLine();

        if (IsValidDate(input))
        {
            Console.WriteLine("Das eingegebene Datum ist korrekt.");
        }
        else
        {
            Console.WriteLine("Das eingegebene Datum ist falsch.");
        }

        static bool IsValidDate(string date)
        {
            DateTime tempDate;
            string format = "dd.MM.yy";
            bool valid = DateTime.TryParseExact(date, format, CultureInfo.InvariantCulture, DateTimeStyles.None,
                out tempDate);
            return valid;
        }
    }
}