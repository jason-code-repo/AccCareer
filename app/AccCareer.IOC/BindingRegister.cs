using AccCareer.DAL.Cqs.Commands;
using AccCareer.DAL.Cqs.Queries;
using AccCareer.DAL.Cqs.Queries.Handlers;
using AccCareer.DAL.Cqs.Queries.Requests;
using AccCareer.DAL.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace AccCareer.IOC;

public static class BindingRegister
{
    public static void SetDependencies(IServiceCollection services)
    {

        SetDal(services);
        SetBll(services);
    }

    private static void SetBll(IServiceCollection services)
    {
        //throw new System.NotImplementedException();
    }

    private static void SetDal(IServiceCollection services)
    {
        services.AddScoped<ICommandDispatcher, CommandDispatcher>();
        services.AddScoped<IQueryDispatcher, QueryDispatcher>();
        services.AddScoped<ICommandDispatcher, CommandDispatcher>();
        
        
        //query handlers
        services.AddScoped<IQueryHandler<GetAll,List<Car>>,GetAllQueryHandler<Car>>();
        services.AddScoped<IQueryHandler<GetAll,List<CarClass>>,GetAllQueryHandler<CarClass>>();
        services.AddScoped<IQueryHandler<GetAll,List<Career>>,GetAllQueryHandler<Career>>();
        services.AddScoped<IQueryHandler<GetAll,List<Manufacturer>>,GetAllQueryHandler<Manufacturer>>();
        services.AddScoped<IQueryHandler<GetAll,List<Track>>,GetAllQueryHandler<Track>>();
        
    }
    
}