namespace game.GameManagement;

public class Game
{
    public string Name { get; set; }
    public List<User> Users { get; } = [];

    public static readonly List<Level> Levels = new List<Level>
    {
        new Level
        {
            ID = 1,
            Name = "Easy",
        },

        new Level
        {
            ID = 2,
            Name = "Intermediate",
        },

        new Level
        {
            ID = 3,
            Name = "Hard",
        },
    
    };

}