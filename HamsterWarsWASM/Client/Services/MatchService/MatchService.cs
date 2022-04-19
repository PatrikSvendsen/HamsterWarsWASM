namespace HamsterWarsWASM.Client.Services.MatchService;

public class MatchService : IMatchService
{
    private readonly HttpClient _http;

    public MatchService(HttpClient http)
    {
        _http = http;
    }

    public List<Match> Matches { get; set; }


    public async Task GetMatches()
    {
        var response = await _http.GetFromJsonAsync<ServiceResponse<List<Match>>>("api/match");
        if (response != null && response.Data != null)
        {
            Matches = response.Data;
        }
    }
}
