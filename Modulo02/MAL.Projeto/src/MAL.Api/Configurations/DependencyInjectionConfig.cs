using MAL.Bussiness.Interfaces;
using MAL.Bussiness.Notificacoes;
using MAL.Bussiness.Services;
using MAL.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAL.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddDependencyInjectionConfig(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoService, ProdutoService>();

            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IFornecedorService, FornecedorService>();

            services.AddScoped<INotificador, Notificador>();

            return services;
        }
    }
}
