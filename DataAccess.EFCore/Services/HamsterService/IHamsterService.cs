using DataAccess.EFCore.Services.GenericService;
using HamsterWarsWASM.Shared.Entities;
using HamsterWarsWASM.Shared.Service;

namespace DataAccess.EFCore.Services.HamsterService;

public interface IHamsterService : IGenericService<Hamster>
{
    /// <summary>
    /// Metod för att uppdatera en specific hamster
    /// </summary>
    /// <param name="hamster">Nya uppdaterade hamstern</param>
    Task<ServiceResponse<Hamster>> Update(Hamster hamster);
    /// <summary>
    /// Metod för att ta bort hamster med specifikt id
    /// </summary>
    Task<ServiceResponse<bool>> Delete(int hamsterId);
}
