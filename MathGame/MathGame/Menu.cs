namespace MathGame
{
	internal class Menu
	{   
		GameEngine gameEngine=new();
		internal void ShowMenu(string name, DateTime date)
		{
			Console.WriteLine($"Hello {name.ToUpper()} today is {date}. Welcome to the math's game!");
			Console.WriteLine("Press any ket to show menu");
			Console.ReadLine();
			Console.Write("\n");
			


			bool isGameOn = true;
			do
			{
				Console.Clear();

				Console.WriteLine(@$"Choose a game you want to play: 
V - view previous games
M - multiplication 
D - division
S - subtraction
A - addition
Q - quit");
				string? operationInput = Console.ReadLine();


				switch (operationInput.Trim().ToLower())
				{
					case "v":
						Helpers.PrintGames();
						break;
					case "m":
						gameEngine.MultiplicationGame("Multiplication game");
						break;
					case "d":
						gameEngine.DivisionGame("Division game");
						break;
					case "s":
						gameEngine.SubtractionGame("Subtraction game");
						break;
					case "a":
						gameEngine.AdditionGame("Addition game");
						break;
					case "q":
						Console.WriteLine("Goodbye");

						isGameOn = false;
						break;
					default:
						Console.WriteLine("Something went wrong. Please check your input.");

						break;
				}
			} while (isGameOn);




		}
	}
}
