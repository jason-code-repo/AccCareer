using AccCareer.DAL.Cqs.Data;
using AccCareer.DAL.Cqs.Queries.Handlers;
using AccCareer.DAL.Cqs.Queries.Requests;
using Microsoft.Extensions.DependencyInjection;

namespace AccCareer.DAL.Cqs.Queries;

public interface IQueryDispatcher
{
    TResult Dispatch<TQuery, TResult>(TQuery query) where TQuery : IQuery where TResult : IResult;
    Task<TResult> DispatchAsync<TQuery, TResult>(TQuery query) where TQuery : IQuery where TResult : IResult;
}

public class QueryDispatcher : IQueryDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public QueryDispatcher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public TResult Dispatch<TQuery, TResult>(TQuery query) where TQuery : IQuery where TResult : IResult
    {
        var handler = _serviceProvider.GetService<IQueryHandler<TQuery, TResult>>();
        return handler.Retrieve(query);
    }

    public async Task<TResult> DispatchAsync<TQuery, TResult>(TQuery query) where TQuery : IQuery where TResult : IResult
    { 
        var handler = _serviceProvider.GetService<IQueryHandler<TQuery, TResult>>();
        return await handler.RetrieveAsync(query);
    }
}