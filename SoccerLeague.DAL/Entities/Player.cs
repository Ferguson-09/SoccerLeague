namespace SoccerLeague.DAL.Entities;

public class Player
{
    public int PlayerId { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public int JerseyNumber { get; set; }

    public string Position { get; set; } = string.Empty;

    public int TeamId { get; set; }

    public Team Team { get; set; } = null!;
}
