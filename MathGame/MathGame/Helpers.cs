using MathGame.Models;
using static MathGame.Models.Game;

namespace MathGame
{
	internal class Helpers
	{
		internal static List<Game> games=new();
			
		internal static void PrintGames()
		{
			Console.Clear();
			Console.WriteLine("Games history:");
			foreach (var game in games)
			{
				Console.WriteLine($"{game.Date}: { game.Type} - { game.Score}");
			}
			Console.WriteLine("Press any key to return to Main menu");
			Console.ReadLine();

		}

		internal static void AddToHistory(int gameScore, GameType gameType)
		{
			games.Add(new Game
			{
				Date=DateTime.Now,
				Type=gameType,
				Score=gameScore
			});
		}

		internal static int[] GetDivisionNumbers()
		{
			var random = new Random();
			int firstNumber = random.Next(1, 99);
			int secondNumber = random.Next(1, 99);
			var result = new int[2];

			while (firstNumber % secondNumber != 0)
			{
				firstNumber = random.Next(1, 99);
				secondNumber = random.Next(1, 99);
			}
			result[0] = firstNumber;
			result[1] = secondNumber;
			return result;
		}

		internal static string? ValidateResult(string result)
		{
			while(string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
				{
				Console.WriteLine("Your number needs to be an integer. Try again!");
				result = Console.ReadLine();
			}
			return result;
		}

internal static string GetName()
	{
		Console.WriteLine("Enter your name: ");
		var name = Console.ReadLine();

			while (string.IsNullOrEmpty(name))
			{
				Console.Write("Name can't be empty");
				name = Console.ReadLine();

			}
		return name;
	}
	}

	


}
