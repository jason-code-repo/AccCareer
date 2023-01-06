using AccCareer.DAL.Cqs.Data;

namespace AccCareer.DAL.Cqs.Queries.Requests;

public interface IQuery : IRequest
{
    
}

public class Query: Request, IQuery
{
    
}