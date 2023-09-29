using SmartScoolApi.Models.Interfaces;

namespace SmartScoolApi.Infra.Repository
{
    public class Repository : IRepository
    {
        public void Add<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll<T>()
        {
            throw new NotImplementedException();
        }

        public T GetById<T>(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
