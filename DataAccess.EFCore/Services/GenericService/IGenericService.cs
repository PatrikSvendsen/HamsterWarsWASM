using HamsterWarsWASM.Shared.Service;

namespace DataAccess.EFCore.Services.GenericService;

public interface IGenericService<T> where T : class
{
    Task<ServiceResponse<List<T>>> GetAll();
    Task<ServiceResponse<T>> GetById(int id);
    Task<ServiceResponse<T>> Insert(T entity);
    Task<ServiceResponse<T>> Update(T entity);
    Task<ServiceResponse<bool>> Delete(int id);
}
