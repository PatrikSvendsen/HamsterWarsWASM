namespace HamsterWarsWASM.Client.Services.HamsterService;

public interface IHamsterService
{
    /// <summary>
    /// Action för att uppdatera hamsters
    /// </summary>
    event Action HamstersChanged;
    /// <summary>
    /// Lista med hamstrar
    /// </summary>
    List<Hamster> Hamsters { get; set; }
    /// <summary>
    /// Metod för att hämta alla hamstrar
    /// </summary>
    /// <returns>Komplett lista med alla hamstrar</returns>
    Task GetHamsters();
    /// <summary>
    /// Metod för att hämta specific hamster via Id
    /// </summary>
    /// <returns>Ett object där Id matchar en hamster i Db</returns>
    Task<ServiceResponse<Hamster>> GetHamster(int hamsterId);
    /// <summary>
    /// Metod för att skapa en specific hamster.
    /// </summary>
    Task<Hamster> CreateHamster(Hamster hamster);
    /// <summary>
    /// Metod för att uppdatera ett object i db
    /// </summary>
    /// <param name="hamster">Det uppdaterade objectet</param>
    Task<Hamster> UpdateHamster(Hamster hamster);
    /// <summary>
    /// Metod som tar bort en hamster i db
    /// </summary>
    Task DeleteHamster(Hamster hamster);
}
