using DataAccess.EFCore.Services.GenericService;
using HamsterWarsWASM.Shared.Entities;
using HamsterWarsWASM.Shared.Service;

namespace DataAccess.EFCore.Services.MatchService;

public interface IMatchService : IGenericService<Match>
{
    /// <summary>
    /// Metod för att hämta alla matcher via specifikt hamster id
    /// </summary>
    /// <returns>En komplett lista med alla matcher där hamster id förekommer</returns>
    Task<ServiceResponse<List<Match>>> GetAllHamsterMatches(int hamsterId);
    /// <summary>
    /// Hämtar alla matcher
    /// </summary>
    /// <returns></returns>
    Task<ServiceResponse<List<Match>>> GetAll(); // GET /matches
    /// <summary>
    /// Tar bort match med id
    /// </summary>
    Task<ServiceResponse<bool>> Delete(int matchId); // DELETE /matches/id

}
