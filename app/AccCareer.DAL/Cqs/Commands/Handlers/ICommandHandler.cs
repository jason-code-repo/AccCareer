using AccCareer.DAL.Cqs.Commands.Requests;
using AccCareer.DAL.Cqs.Data;

namespace AccCareer.DAL.Cqs.Commands.Handlers;

public interface ICommandHandler<in TCommand, TResult> where TCommand : ICommand where TResult : IResult
{
    TResult Handle(TCommand command);
    Task<TResult> HandleAsync(TCommand command);
}
