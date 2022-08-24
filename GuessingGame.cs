using System;
using System.Linq;

namespace MyApplication
{
	class GuessingGame
	{
		static void Main(string[] args)
		{
			string secretWord = "giraffe";
			string guess = "";
			int guessCount = 0;
			int guessLimit = 3;
			bool outOfGuesses = false;
			
			do
			{
				if(guessCount < guessLimit)
				{
				Console.Write("Enter guess: ");
				guess = Console.ReadLine();
				guessCount++;
				}else
				{
					outOfGuesses = true;
				}
				
			}while(guess != secretWord && !outOfGuesses);
			if(outOfGuesses)
			{
				Console.WriteLine("You Lose!");
			}else
			{
				
				Console.Write("You Win!");
			}
				
				Console.ReadLine();
			
			
		
			
		}
	}
}