using AccCareer.DAL.Cqs.Commands.Requests;

namespace AccCareer.DAL.Cqs.Commands.Handlers;

public interface ICommandHandler<in TCommand, TResult> where TCommand : ICommand
{
    TResult Handle(TCommand command);
    Task<TResult> HandleAsync(TCommand command);
}
