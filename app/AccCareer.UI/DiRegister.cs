using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.IO;
using AccCareer.DAL.Context;
using AccCareer.DAL.Cqs.Commands;
using AccCareer.DAL.Cqs.Queries;
using AccCareer.DAL.Cqs.Queries.Handlers;
using AccCareer.DAL.Cqs.Queries.Requests;
using AccCareer.DAL.Entities;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
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
        //throw new System.NotImplementedException();
    }

    private static void SetDal(IServiceCollection services)
    {
        services.AddScoped<ICommandDispatcher, CommandDispatcher>();
        services.AddScoped<IQueryDispatcher, QueryDispatcher>();
        services.AddScoped<ICommandDispatcher, CommandDispatcher>();
        
        
        //query handlers
        services.AddScoped<IQueryHandler<GetAll,List<Car>>,GetAllCarsHandler>();
    }
}