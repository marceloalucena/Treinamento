using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using MAL.Data;
using MAL.Bussiness.Model;
using MAL.Data.Repository;
using MAL.Bussiness.Interfaces;
using AutoMapper;
using MAL.Bussiness.Notificacoes;
using MAL.Api.Configurations;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using HealthChecks.UI.Client;
using MAL.Api.Extentions;

namespace MAL.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<APIContext>(opt => {
                opt.UseSqlServer(Configuration.GetConnectionString("SqlServer"));
            });
            services.AddAutoMapper(typeof(Startup));
            services.AddApiConfig();
            services.AddDependencyInjectionConfig();
            services.AddResponseCaching();
            services.AddResponseCompression(opt => {
                opt.Providers.Add<BrotliCompressionProvider>();
                opt.EnableForHttps = true;
            });
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddXmlDataContractSerializerFormatters()
                .AddJsonOptions(opcoes => 
                {
                    opcoes.SerializerSettings.NullValueHandling =
                        Newtonsoft.Json.NullValueHandling.Ignore;
                });
            services.AddHealthChecks()
                .AddSqlServer(Configuration.GetConnectionString("SqlServer"), name: "BancoSQL")
                .AddCheck("Fornecedores", new SqlServerHealthCheck(Configuration.GetConnectionString("SqlServer")));
            services.AddHealthChecksUI();

            services.AddSwaggerConfig();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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

            app.UseSwaggerConfig();
            app.UseResponseCaching();

            app.UseHealthChecks("/api/hc", new HealthCheckOptions
            {
                Predicate = _ => true,
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });
            app.UseHealthChecksUI();
            
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
