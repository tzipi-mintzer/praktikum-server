using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MyProjectPraktikum.Repository.Entities;
using MyProjectPraktikum.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectPraktikum.Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IContext _context;
        public UserRepository(IContext context)
        {
            _context = context;
        }

        public async Task<User> AddAsync(User user)
        {
            var c = _context.Users.Add(user);
     
            await _context.SaveChangesAsync();
            
            return c.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Users.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }
        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User user)
        {
            User u1 = await GetByIdAsync(user.Id);
            if (u1 != null)
            {
                u1.Tz = user.Tz;
                u1.FirstName = user.FirstName;
                u1.LastName = user.LastName;
                u1.BirthDate = user.BirthDate;
                u1.Gender = user.Gender;
                u1.HMO = user.HMO;
            }
            await _context.SaveChangesAsync();
            return u1;
        }

    }
}
