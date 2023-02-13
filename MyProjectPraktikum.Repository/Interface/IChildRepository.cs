using MyProjectPraktikum.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectPraktikum.Repository.Interface
{
    public interface IChildRepository
    {
        Task<List<Child>> GetAllAsync();

        Task<Child> GetByIdAsync(int id);

        Task<Child> AddAsync(Child child);

        Task<Child> UpdateAsync(Child child);
        Task DeleteAsync(int id);
    }

}
