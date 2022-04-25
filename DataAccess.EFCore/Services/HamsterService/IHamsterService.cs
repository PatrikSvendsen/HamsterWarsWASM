using DataAccess.EFCore.Services.GenericService;
using HamsterWarsWASM.Shared.Entities;
using HamsterWarsWASM.Shared.Service;

namespace DataAccess.EFCore.Services.HamsterService;

public interface IHamsterService : IGenericService<Hamster>
{
    //Task<ServiceResponse<List<Hamster>>> GetHamsters();
    //Task<ServiceResponse<Hamster>> GetHamster(int hamsterId);
    //Task<ServiceResponse<Hamster>> CreateHamster(Hamster hamster);
    Task<ServiceResponse<Hamster>> Update(Hamster hamster);
    Task<ServiceResponse<bool>> Delete(int hamsterId);
    Task<ServiceResponse<List<Hamster>>> GetTop5(string top5);
    Task<ServiceResponse<List<Hamster>>> ShuffleRandomHamsters();
    Task<ServiceResponse<List<Match>>> GetAllHamsterMatches(int hamsterId);
}
