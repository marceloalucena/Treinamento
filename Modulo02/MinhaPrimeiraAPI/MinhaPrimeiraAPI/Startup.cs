using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MinhaPrimeiraAPI.DAL;
using Swashbuckle.AspNetCore.Swagger;

namespace MinhaPrimeiraAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<Contexto, Contexto>();
            services.AddAutoMapper(typeof(Startup));
            services.AddDbContext<Contexto>(options => options.UseInMemoryDatabase(databaseName: "ProdutosInMemory"));
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Minha Primeira API",
                    Description = "Exemplo de API em Asp.net Core",
                    TermsOfService = "https://example.com/terms",
                    Contact = new Contact
                    {
                        Name = "Marcelo Lucena",
                        Email = string.Empty,
                        Url = "https://twitter.com/marceloalucena",
                    },
                    License = new License
                    {
                        Name = "Licença",
                        Url = "https://example.com/license",
                    }
                });
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();
            app.UseMvc();

        }
    }
}
