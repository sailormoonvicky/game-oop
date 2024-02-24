namespace game.GameManagement;

public class Level
{
    public int ID { get; set; }
    public required string Name { get; set; }
    public int HighstScore { get; set; } = 0;
}

