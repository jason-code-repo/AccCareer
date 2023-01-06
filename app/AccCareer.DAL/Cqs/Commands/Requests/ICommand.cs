using AccCareer.DAL.Cqs.Data;

namespace AccCareer.DAL.Cqs.Commands.Requests;

public interface ICommand: IRequest
{
    
}

public class Command: Request, ICommand
{
    
}