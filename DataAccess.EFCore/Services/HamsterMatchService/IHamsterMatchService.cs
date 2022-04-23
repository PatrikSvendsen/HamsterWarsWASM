using DataAccess.EFCore.Services.GenericService;
using HamsterWarsWASM.Shared.Entities;
using HamsterWarsWASM.Shared.Service;

namespace DataAccess.EFCore.Services.HamsterMatchService;

public interface IHamsterMatchService : IGenericService<HamsterMatch>
{
    //Task<ServiceResponse<List<HamsterMatch>>> GetAllHamsterMatches();
    //Task<ServiceResponse<HamsterMatch>> GetHamsterMatch(int hamsterMatchId);
    //Task<ServiceResponse<HamsterMatch>> CreateHamsterMatch(HamsterMatch hamsterMatch);

}
