using System.Data.Common;
using AccCareer.DAL.Cqs.Queries.Requests;
using Microsoft.EntityFrameworkCore;

namespace AccCareer.DAL.Cqs.Queries.Handlers;

public class GetAllQueryHandler<TModel> : IQueryHandler<GetAll, List<TModel>> where TModel : class
{
    private readonly DbContext _context;

    public GetAllQueryHandler(DbContext context)
    {
        _context = context;
    }    
    public List<TModel> Retrieve(GetAll query)
    {
        return _context.Set<TModel>().AsNoTracking().ToList();
    }

    public async Task<List<TModel>> RetrieveAsync(GetAll query)
    {
        return await _context.Set<TModel>().AsNoTracking().ToListAsync();
    }
}