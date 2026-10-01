namespace SoccerLeague.DAL.Entities;

public class Match
{
    public int MatchId { get; set; }

    public DateTime MatchDate { get; set; }

    public int HomeTeamId { get; set; }

    public int AwayTeamId { get; set; }

    public int HomeScore { get; set; }

    public int AwayScore { get; set; }

    public Team HomeTeam { get; set; } = null!;

    public Team AwayTeam { get; set; } = null!;
}