namespace MathGame.Models;

internal class Game
{
	private int _score;

	public int Score
	{

		get { return _score; }
		set { _score = value; }
	}

	public DateTime Date {  get; set; }

	public GameType Type { get; set; }	

	internal enum GameType
	{
		Addition,
		Subtraction, 
		Division,
		Multiplication
	}
}