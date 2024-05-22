# 2024-gruppe-yoda
//Lennox Abdi Mariam
/*

Created by SharpDevelop.
User: lenno
Date: 22.05.2024
Time: 09:34
To change this template use Tools | Options | Coding | Edit Standard Headers.
*/
using System;
using System.Collections;
namespace Zeugnismodell
{
}
class Program
{
public static void Main(string[] args)
{

		String name; 
		String[] geburtsdatum = new string[8];
		int[] Noten = new int[8];
		string[] Fächer = new string[8];
		double durchschnitt = 0;
		
		Console.WriteLine("Name des Schülers eingeben: ");
		name = Console.ReadLine();
		
		
		for(int i =0; i<Noten.Length; i++){
			Console.WriteLine("Fach Nummer" + Fächer[i]);
			Fächer[i] = Convert.ToString(Console.ReadLine());
			Console.WriteLine();
			Console.WriteLine("Note für "+ Fächer[i]);
			Noten[i] = Convert.ToInt32(Console.ReadLine());
			
				for (i = 0; i<Noten.Length; i++){
	
			
			if (i == 0 ){
				Noten[i] *= 2;
			} 
			if (i == 1) {
				
				Noten[i] *= 2;
			}
			
			durchschnitt += Noten[i];
			

		}
			while (Noten[i] > 15 ||Noten[i] <0){
		
		
	}
		
		durchschnitt = (durchschnitt/10);
		
		Console.WriteLine("Dein Notendurchschnitt beträgt: " + durchschnitt);
		Console.ReadKey();
			
		}}
	}