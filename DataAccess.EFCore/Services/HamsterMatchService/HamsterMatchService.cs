using DataAccess.EFCore.Services.GenericService;
using HamsterWarsWASM.Shared.Entities;

namespace DataAccess.EFCore.Services.HamsterMatchService;

public class HamsterMatchService : GenericService<HamsterMatch>, IHamsterMatchService
{
    public HamsterMatchService(DataContext context) : base(context)
    {
    }
}
