namespace MathGame.Game;

public class MathOperations
{
    public Func<int, int, int> add = (x, y) => x + y;
    public Func<int, int, int> multiply = (x, y) => x * y;
    public Func<int, int, int> subtract = (x, y) => x - y;
    public Func<int, int, int> divide = (x, y) => x / y;

}
