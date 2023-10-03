using SmartScoolApi.Domain.DomainModel.Models;

namespace SmartScoolApi.Domain.DomaiModel.Interfaces
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        public Task Add(T entity);
        public Task Update(T entity);
        public Task Delete(Guid id);
        public Task<List<T>> GetAll();
        public Task<T> GetById(Guid id);
        Task<int> SaveChanges();
    }
}
