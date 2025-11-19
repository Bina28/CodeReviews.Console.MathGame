namespace MathGame.Game;

public class GameStarter
{
    private readonly MathOperations _mathOperation;
    private readonly Random random = new();
    private readonly int firstNumber;
    private readonly int secondNumber;

    public GameStarter(MathOperations mathOperation)
    {
        _mathOperation = mathOperation;
        firstNumber = GetNumber();
        secondNumber = GetNumber();
    }

    public int GetNumber() => random.Next(1, 9);

    public static string GetUserNameInput()
    {
        string? name;
        do
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
        }
        while (string.IsNullOrEmpty(name));
        return name;
    }

    public void ShowMenu()
    {
        string name = GetUserNameInput();
        DateTime dateTime = DateTime.UtcNow;
        Console.WriteLine($"Hello {name.ToUpper()} today is {dateTime}. Welcome to the Math game!");
        Console.WriteLine("Press any key to show menu");

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

        while (!string.IsNullOrEmpty(gameInput) || gameInput != "q")
        {

            switch (gameInput?.Trim().ToLower())
            {
                case "h":
                    history.ShowHistory();
                    break;
                case "m":

                    _mathOperation.multiply(firstNumber, secondNumber);
                    break;
                case "d":
                    while (!IsResultInt(firstNumber, secondNumber))
                    {
                        _mathOperation.divide(firstNumber, secondNumber);
                    }

                    break;
                case "a":
                    _mathOperation.add(firstNumber, secondNumber);
                    break;
                case "s":
                PlayGame( firstNumber, secondNumber,   _mathOperation.subtract, '+');
                    break;
                case "q":
                    break;
            }
        }
    }


    public static bool IsResultInt(int firstNumber, int secondNumber)
    {

        return firstNumber % secondNumber == 0;
    }

    public bool IsUserAnswerRight(int userInput, int rightAnswer)
    {
        return userInput == rightAnswer;
    }

    public void PlayGame(int firstNumber, int secondNumber, Func<int, int, int> operation, char opSymbol)
    {
        int rightAnswer = operation(firstNumber, secondNumber);
        string? userInput;
        int userNumber;
        do
        {
            Console.WriteLine($"Enter the result {firstNumber} {operation} {secondNumber}");
            userInput = Console.ReadLine();

        } while (int.TryParse(userInput, out userNumber) || string.IsNullOrEmpty(userInput));

        string result = IsUserAnswerRight(userNumber, rightAnswer) ? ResultMessage(GameResult.RightAnswer) :
                 ResultMessage(GameResult.WrongAnswer);

    }

    public static string ResultMessage(GameResult result)
    {
        string message = result == GameResult.RightAnswer ?
                "Congratulations! Your answer is correct!"
                : "You're answer is wrong";
        return message;
    }

}
