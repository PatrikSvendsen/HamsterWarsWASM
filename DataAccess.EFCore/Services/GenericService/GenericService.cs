using HamsterWarsWASM.Shared.Service;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore.Services.GenericService;

public class GenericService<T> : IGenericService<T> where T : class
{
    protected readonly DataContext _context;

    public GenericService(DataContext context)
    {
        _context = context;
    }
    // Denna delete har ingen generisk då databasen är byggd på att gömma entiteter i databasen och inte ta bort dem helt. Varje class måste ha en egen delete metod
    // Därav blir det en throw om man inte gör en ny delete.
    public virtual async Task<ServiceResponse<bool>> Delete(int id)
    {
        throw new NotImplementedException(); // Man måste göra en override i varje service för classerna.
    }

    public virtual async Task<ServiceResponse<List<T>>> GetAll()
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

    //Finns ingen generisk för update. Varje class/model måste skapa en egen update. Kastar en throw på det inte gjorts.
    public virtual async Task<ServiceResponse<T>> Update(T entity)
    {
        throw new NotImplementedException();
    }
}
