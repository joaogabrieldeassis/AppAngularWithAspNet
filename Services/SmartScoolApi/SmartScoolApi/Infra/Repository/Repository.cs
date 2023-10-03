using Microsoft.EntityFrameworkCore;
using SmartScoolApi.Data;
using SmartScoolApi.Domain.DomaiModel.Interfaces;
using SmartScoolApi.Domain.DomainModel.Models;

namespace SmartScoolApi.Infra.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly DataContext _context;
        protected readonly DbSet<T> _entities;

        public Repository(DataContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task Add(T entity)
        {
            await _entities.AddAsync(entity);
        }

        public async Task Delete(Guid id)
        {
             
            _context.Remove(await _entities.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id));
            await SaveChanges();
        }        

        public async Task<List<T>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> GetById(Guid id)
        {
            return await _entities.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task Update(T entity)
        {
            _entities.Update(entity);
            await SaveChanges();
        }

        public async Task<int> SaveChanges() => _context.SaveChanges();
       
        public void Dispose() => _context?.Dispose();
    }
}
