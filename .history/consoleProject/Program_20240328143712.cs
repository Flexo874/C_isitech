﻿
using  System;
using System.Linq;

namespace consoleProject
{
class Program
{
	static void Main(string[] args)
	{  
		Console.WriteLine("Combien de notes souhaitez-vous entrer ?");
		
		int nombreDeNotes =0;
		
		while(true)
		{
			try
			{
				 nombreDeNotes = Convert.ToInt32(Console.ReadLine());
				break;
			}
			catch(FormatException)
			{
				Console.Error.WriteLine("Argument invalide!"  );
				continue;
			}
		}
		
		
		
		
		
		double[] notes = new double[nombreDeNotes];

		for (int i = 0; i < nombreDeNotes; i++)
		{
			Console.WriteLine($"Entrez la note {i + 1}:");
			notes[i] = getInput();
		}

		double moyenne = CalculerMoyenne(notes);
		Console.WriteLine($"La moyenne des notes est : {moyenne}");

		Console.WriteLine("Les notes supérieures à la moyenne sont : ");
		AfficherNotesSupérieures(notes, moyenne);

		
	  
	}
	
	
	 
		//Exo 1
		public static double getInput()
		{
			while(true)
		{
			try
			{
				double nombreDeNotes = Convert.ToInt32(Console.ReadLine());
				return nombreDeNotes;
				
			}
			catch(FormatException)
			{
				Console.Error.WriteLine("Argument invalide!"  );
				continue;
			}
		}
		}
	static double CalculerMoyenne(double[] notes)
	{
		double somme = 0;
		foreach (double note in notes)
		{
			somme += note;
		}
		return somme / notes.Length;
	}

	static int AfficherNotesSupérieures(double[] notes, double moyenne)
	{
		int count = 0;
		foreach (double note in notes)
		{
			if (note > moyenne)
			{
				Console.WriteLine(note);
				count++;
			}
		}
		return count;
	}
}
}
