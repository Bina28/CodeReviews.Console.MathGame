namespace MathGame.UI;

public class UserInterface : IUserInterface
{
    public void Clear() => Console.Clear();
    public string? ReadInput() => Console.ReadLine();
    public void ReadKey() => Console.ReadKey();
    public void WriteOutput(string message) => Console.Write(message);

}
