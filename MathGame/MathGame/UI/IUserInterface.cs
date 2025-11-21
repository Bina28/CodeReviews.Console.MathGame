namespace MathGame.UI;

public interface IUserInterface
{
    string? ReadInput();
    void WriteOutput(string message);
    void ReadKey();
    void Clear();
}
