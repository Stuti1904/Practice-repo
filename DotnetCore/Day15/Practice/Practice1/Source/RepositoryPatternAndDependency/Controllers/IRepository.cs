using RepositoryPatternAndDependency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternAndDependency.Controllers
{
  public   interface IRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);
        List<TEntity> GetAllEmployees();
        TEntity GetByID(int id);
        TEntity Update(TEntity entity);
        string Delete(int id);
    }
    public class Repository<T> : IRepository<T> where T : class
    {
        public RevisionDBContext contexts { get; set; }
        public Repository(RevisionDBContext context)
        {
            contexts = context;
        }
        public T Add(T entity)
        {
            contexts.Add(entity);
            contexts.SaveChanges();
            return entity;
        }
        public List<T> GetAllEmployees()
        {
            return contexts.Set<T>().Select(x=>x).ToList();
        }
        public T GetByID(int id)
        {
            var emp = contexts.Set<T>().Find(id);
            return emp;
        }
        public T Update( T entity)
        {
            contexts.Update(entity);
            contexts.SaveChanges();
            return entity;

        }
        public string Delete(int id)
        {
            var emptodelete = GetByID(id);
            contexts.Remove(emptodelete);
            contexts.SaveChanges();
            return "DELETED";
        }
    }
}
