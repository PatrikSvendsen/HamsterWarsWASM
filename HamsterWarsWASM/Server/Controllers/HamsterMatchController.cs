using DataAccess.EFCore.Services.HamsterMatchService;
using Microsoft.AspNetCore.Mvc;

namespace HamsterWarsWASM.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HamsterMatchController : ControllerBase
{
    private readonly IHamsterMatchService _hamsterMatchService;

    public HamsterMatchController(IHamsterMatchService hamsterMatchService)
    {
        _hamsterMatchService = hamsterMatchService;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<HamsterMatch>>>> GetAllHamsterMatches()
    {
        var result = await _hamsterMatchService.GetAll();
        return Ok(result);
    }

    [HttpGet("{hamsterMatchId}")]
    public async Task<ActionResult<ServiceResponse<HamsterMatch>>> GetHamsterMatch(int hamsterMatchId)
    {
        var result = await _hamsterMatchService.GetById(hamsterMatchId);
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<HamsterMatch>>> CreateHamsterMatch(HamsterMatch hamsterMatch)
    {
        var result = await _hamsterMatchService.Insert(hamsterMatch);
        return Ok(result);
    }
}
