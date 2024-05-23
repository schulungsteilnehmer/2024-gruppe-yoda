using System;
using System.Globalization;

namespace Zeugnismodell
{
    public class Datum
    {
        public string datum;

        public static string Geburtsdatum()
        {
            Console.WriteLine("Bitte geben Sie Ihr Geburtsdatum ein (DD.MM.YYYY):");
            string input = Console.ReadLine();

            if (IsValidDate(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Das eingegebene Datum ist falsch.");
                return Geburtsdatum(); 
            }
        }

        private static bool IsValidDate(string date)
        {
            DateTime tempDate;
            string format = "dd.MM.yyyy";
            bool valid = DateTime.TryParseExact(date, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out tempDate);
            return valid;
        }
    }
}