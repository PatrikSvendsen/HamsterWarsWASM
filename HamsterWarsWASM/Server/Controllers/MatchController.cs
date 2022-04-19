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
}
