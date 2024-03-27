using consoleProject;
using System;
namespace consoleProject
{
	public static class Utils
	{
		

		public static void printWord (char[] arr)
		{
				Console.Write(arr.ToString());
		}
		
		  public static char GetInput()
		{
			Console.Write("Veuillez saisir une lettre : ");
			char[] letter = Console.ReadLine()!.ToCharArray();
			if (!(letter.Length==1 && Char.IsLetter(letter[0])))
				GetInput();
			return Char.ToLower(letter[0]);
		}
		
		 public static bool ContainsLetter(char[] guessedWord, char letter)
		{
			int i = -1;
			while (++i < guessedWord.Length)
				if (guessedWord[i] == letter) return true;
			return false;
		}
		
		
		
		
		
		
		
		
		
		
		public static void printCase8()
			{
				Console.WriteLine("============");
				Console.WriteLine("|| //    |");
				Console.WriteLine("||//     |");
				Console.WriteLine("||       O");
				Console.WriteLine("||      /|\\");
				Console.WriteLine("||       |");
				Console.WriteLine("||      / \\");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("==========\n");
				
			}
			
			public static void printCase7()
			{
				Console.WriteLine("============");
				Console.WriteLine("|| //    |");
				Console.WriteLine("||//     |");
				Console.WriteLine("||       O");
				Console.WriteLine("||      /|\\");
				Console.WriteLine("||       |");
				Console.WriteLine("||      / ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("==========");
			}
			
			public static void printCase6()
			{
				Console.WriteLine("============");
				Console.WriteLine("|| //    |");
				Console.WriteLine("||//     |");
				Console.WriteLine("||       O");
				Console.WriteLine("||      /|\\");
				Console.WriteLine("||       |");
				Console.WriteLine("||      ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("==========");
			}
			public static void printCase5()
			{
				Console.WriteLine("============");
				Console.WriteLine("|| //    |");
				Console.WriteLine("||//     |");
				Console.WriteLine("||       O");
				Console.WriteLine("||      /|\\");
				Console.WriteLine("||       ");
				Console.WriteLine("||      ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("==========");
			}
			public static void printCase4()
			{
				Console.WriteLine("============");
				Console.WriteLine("|| //    |");
				Console.WriteLine("||//     |");
				Console.WriteLine("||       O");
				Console.WriteLine("||      /|");
				Console.WriteLine("||       |");
				Console.WriteLine("||      ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("==========");
			}
			public static void printCase3()
			{
				Console.WriteLine("============");
				Console.WriteLine("|| //    |");
				Console.WriteLine("||//     |");
				Console.WriteLine("||       O");
				Console.WriteLine("||       |");
				Console.WriteLine("||       |");
				Console.WriteLine("||      ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("==========");
			}
			public static void printCase2()
			{
				Console.WriteLine("============");
				Console.WriteLine("|| //    |");
				Console.WriteLine("||//     |");
				Console.WriteLine("||       O");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("==========");
			}
			
			public static void printCase1()
			{
				Console.WriteLine("============");
				Console.WriteLine("|| //    |");
				Console.WriteLine("||//     |");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("==========");
			}
			
			public static void printCase0()
			{
				Console.WriteLine("============");
				Console.WriteLine("|| //");
				Console.WriteLine("||//");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("==========");
			}
	}
	
	
	
	
}