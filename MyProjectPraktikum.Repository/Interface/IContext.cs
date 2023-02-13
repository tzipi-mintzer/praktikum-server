using Microsoft.EntityFrameworkCore;
using MyProjectPraktikum.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectPraktikum.Repository.Interface
{
    public interface IContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Child> Children { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellation = default);
    }
}
