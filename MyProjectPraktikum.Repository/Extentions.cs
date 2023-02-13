
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using MyProjectPraktikum.Repository.Interface;
using MyProjectPraktikum.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyProjectPraktikum.Repositories
{
    public static class Extentions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IChildRepository, ChildRepository>();

            return services;
        }
   
    }
}
