namespace SoccerLeague.DAL.Entities;

public class Team
{
    public int TeamId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public int FoundedYear { get; set; }

    public ICollection<Player> Players { get; set; }
        = new List<Player>();

    public ICollection<TeamLeague> TeamLeagues { get; set; }
        = new List<TeamLeague>();

    public ICollection<Match> HomeMatches { get; set; }
        = new List<Match>();

    public ICollection<Match> AwayMatches { get; set; }
        = new List<Match>();
}