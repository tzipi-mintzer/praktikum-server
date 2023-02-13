using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using MyProjectPraktikum.Repositories;
using MyProjectPraktikum.Repository.Interface;
using MyProjectPraktikum.Services.Interfaces;
using MyProjectPraktikum.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectPraktikum.Services
{
    public static class Extentions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IChildService, ChildService>();

            services.AddAutoMapper(typeof(Mapping));
            return services;
        }
    }
}
