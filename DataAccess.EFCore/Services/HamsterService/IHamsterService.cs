using HamsterWarsWASM.Shared.Entities;
using HamsterWarsWASM.Shared.Service;

namespace DataAccess.EFCore.Services.HamsterService;

public interface IHamsterService
{
    Task<ServiceResponse<List<Hamster>>> GetHamstersAsync();
    Task<ServiceResponse<Hamster>> GetHamsterAsync(int hamsterId);
    Task<ServiceResponse<Hamster>> CreateHamster(Hamster hamster);
    Task<ServiceResponse<Hamster>> UpdateHamster(Hamster hamster);
    Task<ServiceResponse<bool>> DeleteHamster(int hamsterId);
    Task<ServiceResponse<List<Hamster>>> GetTop5(string top5);
    Task<ServiceResponse<Hamster>> UpdateWinningResult(int hamsterId);
    Task<ServiceResponse<Hamster>> UpdateDefeatedResult(int hamsterId);
}
