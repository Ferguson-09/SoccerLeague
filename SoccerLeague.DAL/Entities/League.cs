namespace SoccerLeague.DAL.Entities;

public class League
{
    public int LeagueId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Country { get; set; } = string.Empty;

    public ICollection<TeamLeague> TeamLeagues { get; set; }
        = new List<TeamLeague>();
}