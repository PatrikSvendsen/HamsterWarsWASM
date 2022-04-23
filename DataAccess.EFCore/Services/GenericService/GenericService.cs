using HamsterWarsWASM.Shared.Service;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore.Services.GenericService;

public class GenericService<T> : IGenericService<T> where T : class
{
    private readonly DataContext _context;

    public GenericService(DataContext context)
    {
        _context = context;
    }

    public virtual async Task<ServiceResponse<bool>> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<ServiceResponse<List<T>>> GetAll()  // Måste lägga till att ta bort Deleted = false.
                                                                  // Annars får man med allt
    {
        var response = new ServiceResponse<List<T>>
        {
            Data = await _context.Set<T>()
            .ToListAsync()
        };
        return response;
    }

    public virtual async Task<ServiceResponse<T>> GetById(int id)
    {
        var response = new ServiceResponse<T>();
        var dbResult = await _context.Set<T>()
            .FindAsync(id);

        if (dbResult == null)
        {
            response.Success = false;
            response.Message = $"No object with this Id:{id}";
        }
        response.Data = dbResult;
        return response;
    }

    public virtual async Task<ServiceResponse<T>> Insert(T entity) // Create
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
        return new ServiceResponse<T> { Data = entity };
    }

    public virtual async Task<ServiceResponse<T>> Update(T entity)
    {
        throw new NotImplementedException();
    }
}
