using DataAccess.EFCore.Services.GenericService;
using HamsterWarsWASM.Shared.Entities;
using HamsterWarsWASM.Shared.Service;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore.Services.MatchService;

public class MatchService : GenericService<Match>, IMatchService
{
    public MatchService(DataContext context) : base(context)
    {
    }

    public async Task<ServiceResponse<List<Match>>> GetAllHamsterMatches(int hamsterId)
    {
        var response = new ServiceResponse<List<Match>>
        {
            Data = await _context.Matches
            .Where(x => x.WinnerId == hamsterId || x.LoserId == hamsterId)
            .ToListAsync()
        };

        return response;
    }

    public override async Task<ServiceResponse<List<Match>>> GetAll()
    {
        var matches = await _context.Matches
            .Include(x => x.Hamsters)
            .ToListAsync();

        return new ServiceResponse<List<Match>>
        {
            Data = matches
        };
    }

    public override async Task<ServiceResponse<bool>> Delete(int matchId)
    {
        var dbMatch = await _context.Matches.FindAsync(matchId);
        if (dbMatch == null)
        {
            return new ServiceResponse<bool>
            {
                Success = false,
                Data = false,
                Message = "Match not found."
            };
        }
        dbMatch.Deleted = true;

        await _context.SaveChangesAsync();
        return new ServiceResponse<bool> { Data = true };
    }

    #region FörArkivetOchFramtiden
    //public async Task<ServiceResponse<Match>> CreateMatch(Match match)
    //{
    //    _context.Matches.Add(match);
    //    await _context.SaveChangesAsync();
    //    return new ServiceResponse<Match> { Data = match };
    //}
    //public async Task<ServiceResponse<Match>> GetMatch(int matchId)
    //{
    //    var response = new ServiceResponse<Match>();
    //    var match = await _context.Matches.FindAsync(matchId);

    //    if (match == null || match.Deleted == true)
    //    {
    //        response.Success = false;
    //        response.Message = $"No match with this Id: {matchId}";
    //    }
    //    response.Data = match;
    //    return response;
    //}
    //public async Task<ServiceResponse<List<Match>>> GetMatches()
    //{
    //    //var matches = await _context.Matches.ToListAsync();
    //    //return new ServiceResponse<List<Match>>
    //    //{
    //    //    Data = matches
    //    //};
    //    var response = new ServiceResponse<List<Match>>
    //    {
    //        Data = await _context.Matches
    //        .Where(x => x.Deleted == false)
    //        .ToListAsync()
    //    };
    //    return response;
    //}
    #endregion
}


