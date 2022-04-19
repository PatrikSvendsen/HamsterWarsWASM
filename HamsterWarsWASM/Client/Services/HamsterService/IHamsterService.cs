namespace HamsterWarsWASM.Client.Services.HamsterService;

public interface IHamsterService
{
    event Action Top5Hamsters;
    event Action HamstersChanged;

    List<Hamster> Hamsters { get; set; }
    Task GetHamsters();
    Task<ServiceResponse<Hamster>> GetHamster(int hamsterId);

    Task<Hamster> CreateHamster(Hamster hamster);
    Task<Hamster> UpdateHamster(Hamster hamster);
    Task DeleteHamster(Hamster hamster);
}
