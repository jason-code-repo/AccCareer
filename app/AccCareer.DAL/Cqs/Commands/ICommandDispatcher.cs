using AccCareer.DAL.Cqs.Commands.Handlers;
using AccCareer.DAL.Cqs.Commands.Requests;
using Microsoft.Extensions.DependencyInjection;

namespace AccCareer.DAL.Cqs.Commands;

public interface ICommandDispatcher
{
    TResult Dispatch<TCommand, TResult>(TCommand command) where TCommand : ICommand;
    Task<TResult> DispatchAsync<TCommand, TResult>(TCommand command) where TCommand : ICommand;
}

public class CommandDispatcher: ICommandDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public CommandDispatcher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    
    public TResult Dispatch<TCommand, TResult>(TCommand command) where TCommand : ICommand
    {
        var handler = _serviceProvider.GetService<ICommandHandler<TCommand, TResult>>();
        return handler.Handle(command);
    }

    public async Task<TResult> DispatchAsync<TCommand, TResult>(TCommand command) where TCommand : ICommand
    {
        var handler = _serviceProvider.GetService<ICommandHandler<TCommand, TResult>>();
        return await handler.HandleAsync(command);
    }
}