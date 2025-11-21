using MathGame.Models;

namespace MathGame.History;

public class HistoryService: IHistoryService
{
    public static void ShowHistory(List<GameModel> games)
    {
        foreach (var game in games)
        {
            Console.WriteLine($"Game name: {game.MenuOptions}, score: {game.Score}, date: {game.DateTime}");
        }
    }
}
