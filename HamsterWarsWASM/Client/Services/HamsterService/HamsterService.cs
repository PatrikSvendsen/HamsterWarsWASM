
namespace HamsterWarsWASM.Client.Services.HamsterService;

public class HamsterService : IHamsterService
{
    private readonly HttpClient _http;

    public HamsterService(HttpClient http)
    {
        _http = http;
    }

    public List<Hamster> Hamsters { get; set; } = new List<Hamster>();

    public event Action Top5Hamsters;

    public async Task<Hamster> CreateHamster(Hamster hamster)
    {
        var result = await _http.PostAsJsonAsync("api/hamster", hamster);
        var newHamster = (await result.Content
            .ReadFromJsonAsync<ServiceResponse<Hamster>>()).Data;

        return newHamster;
    }

    public async Task DeleteHamster(Hamster hamster)
    {
        var result = await _http.DeleteAsync($"api/hamster/{hamster.Id}");
    }

    public async Task<ServiceResponse<Hamster>> GetHamster(int hamsterId)
    {
        var result =
            await _http.GetFromJsonAsync<ServiceResponse<Hamster>>($"api/hamster/{hamsterId}");
        return result;
    }

    public async Task GetHamsters(string? top5 = null)
    {
        var result = top5 == null ?
            await _http.GetFromJsonAsync
                <ServiceResponse<List<Hamster>>>("api/hamster") :
            await _http.GetFromJsonAsync
                <ServiceResponse<List<Hamster>>>("api/hamster/top5");

        if (result != null && result.Data != null) // "Deleted" hamster sorteras bort vid razor.page --bör ses över
        {
            Hamsters = result.Data;
        }

        //Top5Hamsters.Invoke();
    }

    public async Task<Hamster> UpdateHamster(Hamster hamster)
    {
        var result = await _http.PutAsJsonAsync($"api/hamster", hamster);
        return (await result.Content.ReadFromJsonAsync<ServiceResponse<Hamster>>()).Data;
    }
}
