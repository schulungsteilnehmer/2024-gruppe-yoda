using System;

namespace Zeugnismodell
{
    public class Program
    {
        
        
        public static void Main(string[] args)
        {
            Name name = new Name();
            Datum datum = new Datum();
            Durchschnitt durchschnitt = new Durchschnitt();
           

         
          
            datum.datum = Datum.Geburtsdatum();
            name.name = Name.FormatName();
            double berechneterDurchschnitt = Durchschnitt.Durchschnittberechner(durchschnitt);
            
            System.Console.WriteLine("Anzahl deiner Fehltage: ");
            int Fehltage = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Anzahl der unentschuldigten Fehltage: ");
            int unentschuldigteFehltage = Convert.ToInt32(System.Console.ReadLine());
            
            System.Console.WriteLine("===============Zeugnis================");
            System.Console.WriteLine("Name: " + name.name);
            System.Console.WriteLine("Datum: " + datum.datum);
            System.Console.WriteLine("======================================");
            System.Console.WriteLine("/r Gesamte Fehltage: " + Fehltage);
            System.Console.WriteLine("Unentschuldigte Fehltage: " + unentschuldigteFehltage);
            System.Console.WriteLine("Fächer und Noten:");
            foreach (var fachNote in durchschnitt.FachNoten)
            {
                System.Console.WriteLine(fachNote.Fach + ": " + fachNote.Note);
            }
            System.Console.WriteLine("Dein Durchschnitt: " + berechneterDurchschnitt);
            System.Console.WriteLine("======================================");
            
            System.Console.WriteLine("/r Fehltage: "+ Fehltage + "/r Unentschuldigte Fehltage: " + unentschuldigteFehltage);
            if (unentschuldigteFehltage >= 30)
                System.Console.WriteLine("Der Schüler wird nicht versetzt");
            else
                System.Console.WriteLine("Der Schüler wird versetzt");
            System.Console.WriteLine("======================================");

            Anzeigen(unentschuldigteFehltage, Fehltage, berechneterDurchschnitt,datum, name);
            

            
            
            
            
            
            System.Console.ReadKey(true);
        }
        
       

        public static void Anzeigen(int unentschuldigteFehltage, int Fehltage, double berechneterDurchschnitt, Datum datum, Name name)
        {
            String dateiname = @"C:\Users\henta\RiderProjects\2024-gruppe-yoda\Zeugnis.txt";
            StreamWriter sw = new StreamWriter(dateiname);
            Durchschnitt durchschnitt = new Durchschnitt();
            sw.WriteLine("Anzahl deiner unentschuldigten Fehltage: " +unentschuldigteFehltage);
            
            
            sw.WriteLine("===============Zeugnis================");
            sw.WriteLine("Name: " + name);
            
            sw.WriteLine("Geburtsdatum: " + datum);
            sw.WriteLine("======================================");
            sw.WriteLine("/r Gesamte Fehltage: " + Fehltage);
            sw.WriteLine("Unentschuldigte Fehltage: " + unentschuldigteFehltage);
            sw.WriteLine("Fächer und Noten:");
            foreach (var fachNote in durchschnitt.FachNoten)
            {
                sw.WriteLine(fachNote.Fach + ": " + fachNote.Note);
            }
            sw.WriteLine("Dein Durchschnitt: " + berechneterDurchschnitt);
            sw.WriteLine("======================================");
            
            sw.WriteLine("/r Fehltage: "+ Fehltage + "/r Unentschuldigte Fehltage: " + unentschuldigteFehltage);
            if (unentschuldigteFehltage >= 30)
                sw.WriteLine("Der Schüler wird nicht versetzt");
            else
                sw.WriteLine("Der Schüler wird versetzt");
            sw.WriteLine("======================================");
            
            sw.Close();

            
            
        }
    }
}