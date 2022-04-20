﻿using Microsoft.AspNetCore.Mvc;

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
        var result = await _hamsterService.GetHamstersAsync();
        return Ok(result);
    }

    [HttpGet("{hamsterId}")]
    public async Task<ActionResult<ServiceResponse<Hamster>>> GetHamster(int hamsterId)
    {
        var result = await _hamsterService.GetHamsterAsync(hamsterId);
        return Ok(result);
    }

    [HttpGet("top5")]
    public async Task<ActionResult<ServiceResponse<List<Match>>>> GetTop5(string top5 = null)
    {
        var result = await _hamsterService.GetTop5(top5);
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
        var result = await _hamsterService.CreateHamster(hamster);
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult<ServiceResponse<Hamster>>> UpdateHamster(Hamster hamster)
    {
        var result = await _hamsterService.UpdateHamster(hamster);
        return Ok(result);
    }

    [HttpDelete("{hamsterId}")]
    public async Task<ActionResult<ServiceResponse<bool>>> DeleteHamster(int hamsterId)
    {
        var result = await _hamsterService.DeleteHamster(hamsterId);
        return Ok(result);
    }

}