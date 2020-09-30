using Contracts;
using Entities;
using LoggerService;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_OPBA.Extensions
{
    public static class ServiceExtensions
    {
        //communication avec client angular qui possede un autre domaine
        // obligation de mettre en place la policy CORS
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });
        }

        //pour le deploiement sur serveur IIS
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }

        //pour la config du logger
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        //Connexion base de donnée sur le serveur 
        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["sqlserverconnection:connectionString"];
            services.AddDbContext<RepositoryContext>(o => o.UseSqlServer(connectionString));
        }

        //pour implémenter le repository Pattern
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }

        //SWAGGER - documentation for th api
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "OPBA Api",
                    Version = "V1",
                    Description = "An API for BirdsWatchers...",
                    TermsOfService = new Uri("https://digitalcorvax.fr/mentions"),
                    Contact = new OpenApiContact
                    {
                        Name = "Emilie ROBERT",
                        Email = "John.Walkner@gmail.com",
                        Url = new Uri("https://www.linkedin.com/in/emilie-robert-97a52a177/")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "OPBA Api by DigitalCorvax",
                        Url = new Uri("https://digitalcorvax.fr")
                    }
                });
            });
        }
    }
}
