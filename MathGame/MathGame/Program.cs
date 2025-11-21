using MathGame.Game;


GameEngine game = new GameEngine();

string name = GameEngine.GetUserNameInput();
GameEngine.ShowWelcomeMessage(ref name);   
game.ShowMenu();    
