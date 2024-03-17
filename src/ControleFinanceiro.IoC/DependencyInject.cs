using ControleFinanceiro.Application.Mapping;
using ControleFinanceiro.Application.Services;
using ControleFinanceiro.Application.Services.Interfaces;
using ControleFinanceiro.Data.Repositories;
using ControleFinanceiro.Data.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ControleFinanceiro.IoC
{
    public static class DependencyInject
    {
        public static IServiceCollection AddDependencyInject(this IServiceCollection services)
        {
            InjectServices(services);
            InjectRepositories(services);
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
            return services;
        }

        private static IServiceCollection InjectRepositories(this IServiceCollection services)
        {
            services.AddScoped<IReceitaRepository, ReceitaRepository>();
            return services;
        }

        private static IServiceCollection InjectServices(this IServiceCollection services)
        {
            services.AddScoped<IReceitaService, ReceitaService>();
            return services;
        }
    }
}
