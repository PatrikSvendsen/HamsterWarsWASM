using HamsterWarsWASM.Shared.Service;

namespace DataAccess.EFCore.Services.GenericService;

public interface IGenericService<T> where T : class
{
    /// <summary>
    /// Generisk metod för att hämta en lista 
    /// </summary>
    /// <returns>En komplett lista från önskad class/model.</returns>
    Task<ServiceResponse<List<T>>> GetAll();
    /// <summary>
    /// Generisk metod för att hämta ett object
    /// </summary>
    /// <param name="id">Input Id</param>
    /// <returns>Object där Id matchar.</returns>
    Task<ServiceResponse<T>> GetById(int id);
    /// <summary>
    /// Generisk metod för att skapa ett specific object 
    /// </summary>
    /// <param name="entity">Det object som skall skapas</param>
    Task<ServiceResponse<T>> Insert(T entity);
    /// <summary>
    /// Generisk metod för att uppdatera befintligt object i db
    /// </summary>
    /// <param name="entity">Det ny uppdatera objectet</param>
    Task<ServiceResponse<T>> Update(T entity);
    /// <summary>
    /// Generisk metod för att ta bort ett object från db
    /// </summary>
    /// <param name="id">Input Id på det object som skall tas bort</param>
    Task<ServiceResponse<bool>> Delete(int id);
}
