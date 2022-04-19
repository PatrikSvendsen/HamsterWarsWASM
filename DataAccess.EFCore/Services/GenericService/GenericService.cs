using HamsterWarsWASM.Shared.Service;

namespace DataAccess.EFCore.Services.GenericService;

public class GenericService<T> : IGenericService<T> where T : class
{
    protected readonly DataContext _context;

    public GenericService(DataContext context)
    {
        _context = context;
    }

    public virtual async Task<ServiceResponse<T>> Delete(ServiceResponse<T> entity)
    {
        if(entity == null)
        {
            return new ServiceResponse<T>
            {
                Success = false,
                Message = "Item not found"
            };
        }
        _context.Set<ServiceResponse<T>>().Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public virtual async Task<ServiceResponse<T>> GetById(int id)
    {
        return await _context.Set<ServiceResponse<T>>().FindAsync(id);
    }
    public virtual async Task<ServiceResponse<T>> Insert(ServiceResponse<T> entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        _context.Set<ServiceResponse<T>>().Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }




    public virtual Task<IEnumerable<T>> GetAll()
    {
        throw new NotImplementedException();
    }

    public virtual Task<ServiceResponse<T>> Update(T entity)
    {
        throw new NotImplementedException();
    }
}
