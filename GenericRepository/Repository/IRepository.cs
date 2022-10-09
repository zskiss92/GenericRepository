using System.Linq.Expressions;

namespace GenericRepository.Repository
{
    public interface IRepository <T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetFirstOrDefault(Expression<Func<T, bool>>? filter = null);
        void Add(T entity);
        void Remove(T entity);
    }
}
