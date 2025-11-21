namespace MathGame.Game;

public class MathOperations: IOperations
{
    public static readonly Func<int, int, int> add = (x, y) => x + y;
    public static readonly Func<int, int, int> multiply = (x, y) => x * y;
    public static readonly Func<int, int, int> subtract = (x, y) => x - y;
    public static readonly Func<int, int, int> divide = (x, y) => x / y;
}
