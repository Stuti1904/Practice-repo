using Day14P1.Models;

namespace Day14P1
{
    public interface Irepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);
    }
    public class Repository<T> : Irepository<T> where T : class
    {
        public RevisionDBContext DbContext { get; set; }
        public Repository(RevisionDBContext demoDbContext)
        {
            DbContext = demoDbContext;
        }
        public T Add(T entity)
        {
            DbContext.Add(entity);
            DbContext.SaveChanges();
            return entity;
        }
    }
}