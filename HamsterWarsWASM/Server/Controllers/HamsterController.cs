using Microsoft.AspNetCore.Mvc;

namespace HamsterWarsWASM.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HamsterController : ControllerBase
{
    private readonly IHamsterService _hamsterService;

    public HamsterController(IHamsterService hamsterService)
    {
        _hamsterService = hamsterService;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Hamster>>>> GetHamsters()
    {
        var result = await _hamsterService.GetAll();
        return Ok(result);
    }

    [HttpGet("{hamsterId}")]
    public async Task<ActionResult<ServiceResponse<Hamster>>> GetHamster(int hamsterId)
    {
        var result = await _hamsterService.GetById(hamsterId);
        return Ok(result);
    }

    [HttpGet("battle")]
    public async Task<ActionResult<ServiceResponse<List<Hamster>>>> Get2ShuffledHamsters()
    {
        var result = await _hamsterService.ShuffleRandomHamsters();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<Hamster>>> CreateHamster(Hamster hamster)
    {
        var result = await _hamsterService.Insert(hamster);
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult<ServiceResponse<Hamster>>> UpdateHamster(Hamster hamster)
    {
        var result = await _hamsterService.Update(hamster);
        return Ok(result);
    }

    [HttpDelete("{hamsterId}")]
    public async Task<ActionResult<ServiceResponse<bool>>> DeleteHamster(int hamsterId)
    {
        var result = await _hamsterService.Delete(hamsterId);
        return Ok(result);
    }

    [HttpGet("matchwinners/{hamsterId}")]
    public async Task<ActionResult<ServiceResponse<List<Match>>>> GetAllHamsterMatches(int hamsterId)
    {
        var result = await _hamsterService.GetAllHamsterMatches(hamsterId);
        return Ok(result);
    }
}
