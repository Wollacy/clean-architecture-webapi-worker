using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ExampleRepository : IExampleRepository
    {
        private readonly AppDbContext _context;

        public ExampleRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ExampleEntity>> GetAllAsync()
        {
            return await _context.ExampleEntities.ToListAsync();
        }

        public async Task<ExampleEntity> GetByIdAsync(int id)
        {
            return await _context.ExampleEntities.FindAsync(id);
        }

        public async Task AddAsync(ExampleEntity entity)
        {
            _context.ExampleEntities.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ExampleEntity entity)
        {
            _context.ExampleEntities.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.ExampleEntities.FindAsync(id);
            if (entity != null)
            {
                _context.ExampleEntities.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
