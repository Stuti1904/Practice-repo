using Day15A1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day15A1.Controllers
{
   public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity GetOne(int id);
        TEntity Add(TEntity entity);

        TEntity update(TEntity entity);
        string Delete(int id);
    }

    public class Repository<T> : IRepository<T> where T : class
    {
        public NewDBContext contexts { get; set; }
        public Repository(NewDBContext context)
        {
            contexts = context;
        }
        public T Add(T entity)
        {
            contexts.Add(entity);
            contexts.SaveChanges();
            return entity;
        }
        public List<T> GetAll()
        {
            return contexts.Set<T>().Select(x => x).ToList();
        }
        public T GetOne(int id)
        {
            var temp = contexts.Set<T>().Find(id);
            return temp;
        }
        public T update(T entity)
        {

            contexts.Update(entity);
            contexts.SaveChanges();
            return entity;

        }
        public string Delete(int id)
        {
            var emptodelete = GetOne(id);
            contexts.Remove(emptodelete);
            contexts.SaveChanges();
            return "DELETED";
        }
    }
       
}
