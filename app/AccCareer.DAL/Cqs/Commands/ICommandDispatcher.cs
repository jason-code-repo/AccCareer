using AccCareer.DAL.Cqs.Commands.Handlers;
using AccCareer.DAL.Cqs.Commands.Requests;
using AccCareer.DAL.Cqs.Data;
using Microsoft.Extensions.DependencyInjection;

namespace AccCareer.DAL.Cqs.Commands;

public interface ICommandDispatcher
{
    TResult Dispatch<TCommand, TResult>(TCommand command) where TCommand : ICommand where TResult : IResult;
    Task<TResult> DispatchAsync<TCommand, TResult>(TCommand command) where TCommand : ICommand where TResult : IResult;
}

public class CommandDispatcher: ICommandDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public CommandDispatcher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    
    public TResult Dispatch<TCommand, TResult>(TCommand command) where TCommand : ICommand where TResult : IResult
    {
        var handler = _serviceProvider.GetService<ICommandHandler<TCommand, TResult>>();
        return handler.Handle(command);
    }

    public async Task<TResult> DispatchAsync<TCommand, TResult>(TCommand command) where TCommand : ICommand where TResult : IResult
    {
        var handler = _serviceProvider.GetService<ICommandHandler<TCommand, TResult>>();
        return await handler.HandleAsync(command);
    }
}