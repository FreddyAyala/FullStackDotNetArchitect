using FullStack.Application.Services;
using FullStack.Domain.Interfaces;
using FullStack.Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStack.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Fullstack.Core

            services.AddScoped<ITodoService, TodoService>();
            //FullStack.Domain.Interfaces and repositories
            services.AddScoped<IToDoRepository, TodoRepository>();
        }
    }
}
