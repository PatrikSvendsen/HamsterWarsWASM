using HamsterWarsWASM.Shared.Entities;
using HamsterWarsWASM.Shared.Service;

namespace DataAccess.EFCore.Services.MatchService;

public interface IMatchService
{
    Task<ServiceResponse<List<Match>>> GetMatches();
}
