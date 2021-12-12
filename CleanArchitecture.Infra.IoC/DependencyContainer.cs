using CleanArchitecture.Application.Services;
using CleanArchitecture.Application.Interfaces;
using CoreCleanArchitecture.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreCleanArchitecture.Infrastructure.Data.Repositories;
using IProjectRepository = CoreCleanArchitecture.Domain.Interfaces.IProjectRepository;

namespace CleanArchitecture.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
        }
    }
}
