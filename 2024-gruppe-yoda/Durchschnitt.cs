using System;

namespace Zeugnismodell
{
    public class Durchschnitt
    {
        public FachNote[] FachNoten { get; private set; } = new FachNote[8];
        
        public static double Durchschnittberechner(Durchschnitt durchschnittObj)
        {
            double durchschnitt = 0;
            for (int i = 0; i < durchschnittObj.FachNoten.Length; i++)
            {
                if (i < 2) 
                {
                    Console.WriteLine("Leistungskurs " + (i + 1) + " eingeben: ");
                }
                else
                {
                    Console.WriteLine("Grundkurs " + (i + 1) + " eingeben: ");
                }

                string fach = Console.ReadLine();
                Console.WriteLine("Note für " + fach + " eingeben: ");
                int note = Convert.ToInt32(Console.ReadLine());

                durchschnittObj.FachNoten[i] = new FachNote { Fach = fach, Note = note };
            }

            for (int i = 0; i < durchschnittObj.FachNoten.Length; i++)
            {
                int gewichteteNote = durchschnittObj.FachNoten[i].Note;
                if (i < 2) 
                {
                    gewichteteNote *= 2;
                }

                durchschnitt += gewichteteNote;
            }

            durchschnitt = durchschnitt / 10;
            
            return durchschnitt;
        }
    }

    public class FachNote
    {
        public string Fach { get; set; }
        public int Note { get; set; }
    }
}