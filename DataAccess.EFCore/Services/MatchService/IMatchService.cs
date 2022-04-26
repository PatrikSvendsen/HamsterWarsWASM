using DataAccess.EFCore.Services.GenericService;
using HamsterWarsWASM.Shared.Entities;
using HamsterWarsWASM.Shared.Service;

namespace DataAccess.EFCore.Services.MatchService;

public interface IMatchService : IGenericService<Match>
{
    //Task<ServiceResponse<List<Match>>> GetMatches(); // GET /matches
    //Task<ServiceResponse<Match>> GetMatch(int matchId); // GET /matches/id
    //Task<ServiceResponse<Match>> CreateMatch(Match match); // POST /matches
    //Task<ServiceResponse<bool>> DeleteMatch(int matchId); // DELETE /matches/id

    Task<ServiceResponse<List<Match>>> GetAllHamsterMatches(int hamsterId);
}
