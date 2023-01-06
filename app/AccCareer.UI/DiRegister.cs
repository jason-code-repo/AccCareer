using AccCareer.DAL.Cqs;
using AccCareer.DAL.Cqs.Commands;
using AccCareer.DAL.Cqs.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace AccCareer.UI;

public static class DiRegister
{
    public static void Set(IServiceCollection services)
    {

        SetDal(services);
        SetBll(services);
    }

    private static void SetBll(IServiceCollection services)
    {
        throw new System.NotImplementedException();
    }

    private static void SetDal(IServiceCollection services)
    {
        services.AddScoped<ICommandDispatcher, CommandDispatcher>();
        services.AddScoped<IQueryDispatcher, QueryDispatcher>();
    }
}