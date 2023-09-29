namespace SmartScoolApi.Models.Interfaces
{
    public interface IRepository
    {
        public void Add<T>(T entity);
        public void Update<T>(T entity);
        public void Delete<T>(T entity);
        public List<T> GetAll<T>();
        public T GetById<T>(Guid id);    
    }
}
