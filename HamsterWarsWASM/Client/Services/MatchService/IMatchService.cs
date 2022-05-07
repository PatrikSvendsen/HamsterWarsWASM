namespace HamsterWarsWASM.Client.Services.MatchService;

public interface IMatchService
{
    /// <summary>
    /// Action för att uppdatera match listan
    /// </summary>
    event Action OnChange;
    /// <summary>
    /// Lista med matches
    /// </summary>
    List<Match> Matches { get; set; }
    /// <summary>
    /// Metod för att hämta alla matcher
    /// </summary>
    Task GetMatches();
    /// <summary>
    /// Metod för att hämta specific match via Id
    /// </summary>
    /// <returns>Returnerar en match om Id matchar</returns>
    Task<ServiceResponse<Match>> GetMatch(int matchId);
    /// <summary>
    /// Metod för att Skapa en match.
    /// </summary>
    Task<Match> CreateMatch(Match match);
    /// <summary>
    /// Metod för att ta bort en match
    /// </summary>
    Task DeleteMatch(Match match);
    /// <summary>
    /// Metod för att hämta alla matcher där hamster id matchar WinnerId eller LoserId
    /// </summary>
    Task GetAllHamsterMatches(int hamsterId);
}
