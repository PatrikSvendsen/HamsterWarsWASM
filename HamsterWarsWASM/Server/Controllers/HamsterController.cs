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
    /// <summary>
    /// API för att hämta alla hamstrar
    /// </summary>
    /// <returns>Returnerar 200 OK</returns>
    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Hamster>>>> GetHamsters()
    {
        var result = await _hamsterService.GetAll();
        return Ok(result);
    }
    /// <summary>
    /// API för att hämta specific hamster vid Id
    /// </summary>
    /// <param name="hamsterId">Specifict hamster id</param>
    /// <returns>Returnerar 200 OK om hamstern finns.</returns>
    [HttpGet("{hamsterId}")]
    public async Task<ActionResult<ServiceResponse<Hamster>>> GetHamster(int hamsterId)
    {
        var result = await _hamsterService.GetById(hamsterId);
        return Ok(result);
    }
    /// <summary>
    /// API som tar emot ett hamster objekt och skickar det vidare till service lagret. 
    /// </summary>
    /// <param name="hamster">Komplett object av en hamster</param>
    /// <returns>Returnerar 200 OK om man lyckats föda hamstern.</returns>
    [HttpPost]
    public async Task<ActionResult<ServiceResponse<Hamster>>> CreateHamster(Hamster hamster)
    {
        var result = await _hamsterService.Insert(hamster);
        return Ok(result);
    }
    /// <summary>
    /// API för att uppdatera en specific hamster.
    /// </summary>
    /// <param name="hamster">Komplett object av en hamster som skall uppdateras.</param>
    /// <returns>Returnerar 200 OK om man lyckats uppdatera hamstern.</returns>
    [HttpPut]
    public async Task<ActionResult<ServiceResponse<Hamster>>> UpdateHamster(Hamster hamster)
    {
        var result = await _hamsterService.Update(hamster);
        return Ok(result);
    }
    /// <summary>
    /// API för att ta bort en hamster via Id
    /// </summary>
    /// <param name="hamsterId">Hamster id</param>
    /// <returns>Returnerar 200 OK om man lyckats ta bort hamstern</returns>
    [HttpDelete("{hamsterId}")]
    public async Task<ActionResult<ServiceResponse<bool>>> DeleteHamster(int hamsterId)
    {
        var result = await _hamsterService.Delete(hamsterId);
        return Ok(result);
    }
}
