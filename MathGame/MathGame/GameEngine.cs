namespace MathGame
{
	internal class GameEngine
	{
	internal void AdditionGame(string message)
	{
		Console.Clear();
		Console.WriteLine(message);
		var random = new Random();
		int firstNumber;
		int secondNumber;
		var score = 0;

		for (int i = 0; i < 5; i++)
		{
			firstNumber = random.Next(1, 9);
			secondNumber = random.Next(1, 9);
			Console.WriteLine($"{firstNumber} + {secondNumber}");
			var result = Console.ReadLine();

			result=	Helpers.ValidateResult(result);

				

			if (int.Parse(result) == firstNumber + secondNumber)
			{
				Console.WriteLine("Your answer was correct! Type any key for the next question!");
				score++;
			}
			else
			{
				Console.WriteLine("Your answer wasn't correct! Type any key for the next question!");
			}

			if (i == 4) Console.WriteLine($"Game over! You score is {score}");
		}

		Helpers.AddToHistory(score, Models.Game.GameType.Addition);


	}
		internal void SubtractionGame(string message)
		{
			Console.Clear();
			Console.WriteLine(message);
			var random = new Random();
			int firstNumber;
			int secondNumber;
			var score = 0;

			for (int i = 0; i < 5; i++)
			{
				firstNumber = random.Next(1, 9);
				secondNumber = random.Next(1, 9);
				Console.WriteLine($"{firstNumber} - {secondNumber}");
				var result = Console.ReadLine();
				result = Helpers.ValidateResult(result);

				if (int.Parse(result) == firstNumber - secondNumber)
				{
					Console.WriteLine("Your answer was correct! Type any key for the next question!");
					score++;
				}
				else
				{
					Console.WriteLine("Your answer wasn't correct! Type any key for the next question!");
				}

				if (i == 4) Console.WriteLine($"Game over! You score is {score}");
			}
			Helpers.AddToHistory(score, Models.Game.GameType.Subtraction);
		}
		internal void DivisionGame(string message)
		{
			Console.Clear();
			Console.WriteLine(message);
			var score = 0;

			for (int i = 0; i < 5; i++)
			{
				var divisionNumbers = Helpers.GetDivisionNumbers();
				var firstNumber = divisionNumbers[0];
				var secondNumber = divisionNumbers[1];

				Console.WriteLine($"{firstNumber} / {secondNumber}");
				var result = Console.ReadLine();
				result = Helpers.ValidateResult(result);
				if (int.Parse(result) == firstNumber / secondNumber)
				{
					Console.WriteLine("Your answer was correct! Type any key for the next question!");
					score++;
				}
				else
				{
					Console.WriteLine("Your answer wasn't correct! Type any key for the next question!");
				}

				if (i == 4) Console.WriteLine($"Game over! You score is {score}");
			}
			Helpers.AddToHistory(score, Models.Game.GameType.Division);
		}
		internal void MultiplicationGame(string message)
		{
			Console.Clear();
			Console.WriteLine(message);
			var random = new Random();
			int firstNumber;
			int secondNumber;
			var score = 0;

			for (int i = 0; i < 5; i++)
			{
				firstNumber = random.Next(1, 9);
				secondNumber = random.Next(1, 9);
				Console.WriteLine($"{firstNumber} * {secondNumber}");
				var result = Console.ReadLine();
				result = Helpers.ValidateResult(result);
				if (int.Parse(result) == firstNumber * secondNumber)
				{
					Console.WriteLine("Your answer was correct! Type any key for the next question!");
					score++;
				}
				else
				{
					Console.WriteLine("Your answer wasn't correct! Type any key for the next question!");
				}

				if (i == 4) Console.WriteLine($"Game over! You score is {score}");
			}
			Helpers.AddToHistory(score, Models.Game.GameType.Multiplication);
		}

	}


}

