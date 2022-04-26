namespace HamsterWarsWASM.Client.Services.MatchService;

public interface IMatchService
{
    List<Match> Matches { get; set; }
    Task GetMatches();
    Task<ServiceResponse<Match>> GetMatch(int matchId);
    Task<Match> CreateMatch(Match match);
    Task DeleteMatch(Match match);

    Task GetTop5();
    Task GetBott5();
}
