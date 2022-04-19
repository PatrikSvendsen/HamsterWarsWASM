namespace HamsterWarsWASM.Client.Services.MatchService;

public interface IMatchService
{
    List<Match> Matches { get; set; }
    Task GetMatches();
}
