using AccCareer.DAL.Cqs.Queries.Requests;
using AccCareer.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccCareer.DAL.Cqs.Queries.Handlers;

public class GetAllCarsHandler : IQueryHandler<GetAll, List<Car>>
{
    private readonly DbContext _context;

    public GetAllCarsHandler(DbContext context)
    {
        _context = context;
    }
    public List<Car> Retrieve(GetAll query)
    {
        return _context.Set<Car>().AsNoTracking().ToList();
    }

    public async Task<List<Car>> RetrieveAsync(GetAll query)
    {
        return await _context.Set<Car>().AsNoTracking().ToListAsync();
    }
}
