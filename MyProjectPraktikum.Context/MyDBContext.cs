using Microsoft.EntityFrameworkCore;
using MyProjectPraktikum.Repository.Entities;
using MyProjectPraktikum.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectPraktikum.Context
{
    public class MyDBContext : DbContext, IContext
    {
        public DbSet<User> Users { get; set; } 
        public DbSet<Child> Children { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=sqlsrv;Initial Catalog=tzipiPraktikum;Integrated Security=True;Trusted_connection=True");
        }

    }
}
