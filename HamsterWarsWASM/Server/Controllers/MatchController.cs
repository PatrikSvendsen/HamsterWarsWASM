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

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Match>>>> GetMatches()
    {
        var result = await _matchService.GetMatches();
        return Ok(result);
    }

    [HttpGet]
    [Route("{matchId}")]
    public async Task<ActionResult<ServiceResponse<Match>>> GetMatch(int matchId)
    {
        var result = await _matchService.GetMatch(matchId);
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<Match>>> CreateMatch(Match match)
    {
        var result = await _matchService.CreateMatch(match);
        return Ok(result);
    }

    [HttpDelete]
    [Route("{matchId}")]
    public async Task<ActionResult<ServiceResponse<bool>>> DeleteMatch(int matchId)
    {
        var result = await _matchService.DeleteMatch(matchId);
        return Ok(result);
    }


}
