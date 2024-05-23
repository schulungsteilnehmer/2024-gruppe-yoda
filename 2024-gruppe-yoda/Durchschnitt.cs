namespace Zeugnismodell;

public class Durchschnitt
{
    public static void Durchschnittberechner()
    {
        int[] noten = new int[8];
        string[] fächer = new string[8];
        double durchschnitt = 0;
        for (int i = 0; i < noten.Length; i++)
        {
            if (noten[i] < 2)
            {
                Console.WriteLine("Leistungskurs " + (i + 1) + " eingeben: ");
            }

            fächer[i] = Console.ReadLine();
            Console.WriteLine("Note für " + fächer[i] + " eingeben: ");
            noten[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < noten.Length; i++)
        {
            if (i == 0 || i == 1)
            {
                noten[i] *= 2;
            }

            durchschnitt += noten[i];
        }

        durchschnitt = (durchschnitt / 10);

        Console.WriteLine("Dein Notendurchschnitt beträgt: " + durchschnitt);
        Console.ReadKey();
    }
}