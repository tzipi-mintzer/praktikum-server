using Microsoft.EntityFrameworkCore;
using MyProjectPraktikum.Repository.Entities;
using MyProjectPraktikum.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectPraktikum.Repository.Repositories
{
    public class ChildRepository : IChildRepository
    {
        private readonly IContext _context;
        public ChildRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Child> AddAsync(Child child)
        {
            var c = _context.Children.Add(child);
            await _context.SaveChangesAsync();
            return c.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Children.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {

            return await _context.Children.ToListAsync();
        }

        public async Task<Child> GetByIdAsync(int id)
        {

            return await _context.Children.FindAsync(id);
        }

        public async Task<Child> UpdateAsync(Child child)
        {
            Child c1 = await GetByIdAsync(child.Id);
            if (c1 != null)
            {
                c1.FirstName = child.FirstName;
                c1.BirthDate = child.BirthDate;
                c1.Tz = child.Tz;
                c1.ParentId= child.ParentId;
            }
            await _context.SaveChangesAsync();
            return c1;
        }
    }
}
