namespace game.GameManagement;

public class User
{
    public int Id { get; set; }
    public required string UserName { get; set; }
    public required string Password { private get; set; }
    public Level CurrentLevel { get; private set; } = Game.Levels.First();

    public void AdvanceLevel(int score)
    {
        if (score > CurrentLevel.HighstScore)
            {
                CurrentLevel.HighstScore = score;
                Console.WriteLine($"Congratulations! New high score {CurrentLevel.HighstScore} for level {CurrentLevel.Name}.");
            }
        if (CurrentLevel == Game.Levels.Last())
        {

            Console.WriteLine($"Well done {UserName}! You've finished the game!");
        }
        else
        {
            var currentLevelIndex = Game.Levels.IndexOf(CurrentLevel);
            CurrentLevel = Game.Levels[currentLevelIndex + 1];
            Console.WriteLine($"You're now on Level {CurrentLevel.ID}: {CurrentLevel.Name}.");

        }
    }
}