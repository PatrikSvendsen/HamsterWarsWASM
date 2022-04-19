using HamsterWarsWASM.Shared.Service;

namespace DataAccess.EFCore.Services.GenericService;

public interface IGenericService<T> where T : class
{
    Task<ServiceResponse<T>> GetById(int id);
    Task<IEnumerable<T>> GetAll();
    Task<ServiceResponse<T>> Insert(ServiceResponse<T> entity);
    Task<ServiceResponse<T>> Update(T entity);
    Task<ServiceResponse<T>> Delete(ServiceResponse<T> entity);
}
