using AccCareer.DAL.Cqs.Data;
using AccCareer.DAL.Cqs.Queries.Requests;

namespace AccCareer.DAL.Cqs.Queries.Handlers;

public interface IQueryHandler<in TQuery, TResult> where TResult : IResult where TQuery : IQuery
{
    TResult Retrieve(TQuery query);
    Task<TResult> RetrieveAsync(TQuery query);
}