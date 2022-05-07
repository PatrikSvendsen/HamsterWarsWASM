namespace HamsterWarsWASM.Client.Services.MatchService;

public class MatchService : IMatchService
{
    private readonly HttpClient _http;

    public MatchService(HttpClient http)
    {
        _http = http;
    }

    public List<Match> Matches { get; set; }

    public event Action OnChange;

    public async Task<Match> CreateMatch(Match match)
    {
        var result = await _http.PostAsJsonAsync("api/match", match);
        var newMatch = (await result.Content
            .ReadFromJsonAsync<ServiceResponse<Match>>()).Data;
        return newMatch;
    }

    public async Task DeleteMatch(Match match)
    {
        var result = await _http.DeleteAsync($"api/match/{match.Id}");
    }

    public async Task GetAllHamsterMatches(int hamsterId)
    {
        var response = await _http.GetFromJsonAsync<ServiceResponse<List<Match>>>($"api/match/matchwinners/{hamsterId}");
        if (response != null && response.Data != null)
        {
            Matches = response.Data;
        }
    }

    public async Task<ServiceResponse<Match>> GetMatch(int matchId)
    {
        var result = await _http.GetFromJsonAsync<ServiceResponse<Match>>($"api/match/{matchId}");
        return result;
    }

    public async Task GetMatches()
    {
        var response = await _http.GetFromJsonAsync<ServiceResponse<List<Match>>>("api/match");
        if (response != null && response.Data != null)
        {
            Matches = response.Data;
        }
    }
}
