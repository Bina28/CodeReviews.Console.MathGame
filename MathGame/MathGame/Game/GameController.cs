using MathGame.History;
using MathGame.Models;
using MathGame.UI;

namespace MathGame.Game;

public class GameController
{
    private readonly IUserInterface _userInterface;
    public GameController(UserInterface userInterface) {
    _userInterface = userInterface;
    }

    public string GetUserNameInput()
    {
        string? name;
        do
        {
            _userInterface.WriteOutput("Please enter your name");
           
            name = _userInterface.ReadInput();
        }
        while (string.IsNullOrEmpty(name));
        return name;
    }

    public void ShowWelcomeMessage(ref string name)
    {
        DateTime dateTime = DateTime.UtcNow;
        _userInterface.WriteOutput($"Hello {name.ToUpper()} today is {dateTime}. Welcome to the Math game!");
    }

    public void ShowMenu()
    {
        while (true)
        {

            Console.WriteLine(@$"Choose a game you want to play:
             h-{MenuOptions.History}
             m-{MenuOptions.Multiplication}
             d-{MenuOptions.Division}
             a-{MenuOptions.Addition}
             s-{MenuOptions.Subtraction}
             q-{MenuOptions.Quit}
           "
    );

            string? gameInput = Console.ReadLine();

            switch (gameInput?.Trim().ToLower())
            {
                case "h":
                    HistoryService.ShowHistory(games);
                    break;
                case "m":
                    PlayGame(firstNumber, secondNumber, MathOperations.multiply, '*', MenuOptions.Multiplication);
                    break;
                case "d":
                    PlayGame(firstNumber, secondNumber, MathOperations.divide, '/', MenuOptions.Division);
                    break;
                case "a":
                    PlayGame(firstNumber, secondNumber, MathOperations.add, '+', MenuOptions.Addition);
                    break;
                case "s":
                    PlayGame(firstNumber, secondNumber, MathOperations.subtract, '-', MenuOptions.Subtraction);
                    break;
                case "q":
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invlaid input");
                    break;
            }
        }
    }
    public static void ResultMessage(GameResult result)
    {
        string message = result == GameResult.RightAnswer ?
                "Congratulations! Your answer is correct!"
                : "You're answer is wrong";
        Console.WriteLine(message);
    }

}
