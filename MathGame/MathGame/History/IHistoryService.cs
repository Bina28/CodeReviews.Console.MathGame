using MathGame.Models;

namespace MathGame.History;

public interface IHistoryService<T> 
{
    void ShowHistory(List<T> items);
}
