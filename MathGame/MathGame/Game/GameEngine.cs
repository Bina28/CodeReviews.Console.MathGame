using MathGame.Models;

namespace MathGame.Game;

public class GameEngine
{
    private readonly Random random = new();
    private readonly int firstNumber;
    private readonly int secondNumber;
    private readonly List<GameModel> games = [];

    public GameEngine()
    {
        firstNumber = GetNumber();
        secondNumber = GetNumber();
    }

    public int GetNumber() => random.Next(1, 9);



    public static bool IsResultInt(int firstNumber, int secondNumber)
    {

        return firstNumber % secondNumber == 0;
    }

    public static bool IsUserAnswerRight(int userInput, int rightAnswer)
    {
        return userInput == rightAnswer;
    }

    public void PlayGame(int firstNumber, int secondNumber,
        Func<int, int, int> operation, char opSymbol, MenuOptions menu
        )
    {
        if (operation == MathOperations.divide)
        {
            while (!IsResultInt(firstNumber, secondNumber))
            {
                firstNumber = GetNumber();
                secondNumber = GetNumber();
            }
        }


        int rightAnswer = operation(firstNumber, secondNumber);
        string? userInput;
        int userNumber;
        int score = 0;

        do
        {
            Console.WriteLine($"Enter the result {firstNumber} {opSymbol} {secondNumber}");
            userInput = Console.ReadLine();

        } while (!int.TryParse(userInput, out userNumber) || string.IsNullOrEmpty(userInput));

        if (IsUserAnswerRight(userNumber, rightAnswer))
        {
            ResultMessage(GameResult.RightAnswer);
            score++;
        }
        else
        {
            ResultMessage(GameResult.WrongAnswer);
        }

        games.Add(new GameModel
        {
            DateTime = DateTime.Now,
            Score = score,
            MenuOptions = menu,
        });

        Console.WriteLine("Press any key to go back to main menu");
        Console.ReadKey();
  

    }



}
