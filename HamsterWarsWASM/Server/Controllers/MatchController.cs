using Microsoft.AspNetCore.Mvc;

namespace HamsterWarsWASM.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MatchController : ControllerBase
{
    private readonly IMatchService _matchService;

    public MatchController(IMatchService matchService)
    {
        _matchService = matchService;
    }
    /// <summary>
    /// API för att hämta alla matcher
    /// </summary>
    /// <returns>Komplett lista med alla matcher</returns>
    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Match>>>> GetMatches()
    {
        var result = await _matchService.GetAll();
        return Ok(result);
    }
    /// <summary>
    /// API för att hämta specifik match med Id
    /// </summary>
    /// <param name="matchId">Specifikt match id</param>
    /// <returns>Ett objekt av input id</returns>
    [HttpGet]
    [Route("{matchId}")]
    public async Task<ActionResult<ServiceResponse<Match>>> GetMatch(int matchId)
    {
        var result = await _matchService.GetById(matchId);
        return Ok(result);
    }
    /// <summary>
    /// API för att skapa en match 
    /// </summary>
    /// <param name="matchId">Specifikt match id</param>
    /// <returns>Returnerar 200 OK om det lyckas.</returns>
    [HttpPost]
    public async Task<ActionResult<ServiceResponse<Match>>> CreateMatch(Match match)
    {
        var result = await _matchService.Insert(match);
        return Ok(result);
    }
    /// <summary>
    /// API för att ta bort specific match via Id
    /// </summary>
    /// <param name="matchId">Specifikt match id</param>
    /// <returns>Returnerar 200 OK vid lyckat försök.</returns>
    [HttpDelete]
    [Route("{matchId}")]
    public async Task<ActionResult<ServiceResponse<bool>>> DeleteMatch(int matchId)
    {
        var result = await _matchService.Delete(matchId);
        return Ok(result);
    }

    /// <summary>
    /// Hämtar alla matcher där input {hamsterId} matchar WinnerId eller LoserId i någon match.
    /// </summary>
    /// <param name="hamsterId">Specifikt hamster id</param>
    /// <returns>Returnerar 200 OK och en lista med alla matchande matcher.</returns>
    [HttpGet("matchwinners/{hamsterId}")]
    public async Task<ActionResult<ServiceResponse<List<Match>>>> GetAllHamsterMatches(int hamsterId)
    {
        var result = await _matchService.GetAllHamsterMatches(hamsterId);
        return Ok(result);
    }
}
