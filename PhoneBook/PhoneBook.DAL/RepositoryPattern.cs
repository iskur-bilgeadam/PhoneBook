using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.DAL
{
    public class RepositoryPattern<T> where T : class
    {
        DataContext db = new DataContext();
        public List<T> List()
        {
            return db.Set<T>().ToList();
        }
        public T Find(Expression<Func<T, bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);

        }
        public List<T> List(Expression<Func<T, bool>> where)
        {
            return db.Set<T>().Where(where).ToList();
        }
        public void Delete(T obj)
        {
            db.Set<T>().Remove(obj);
            db.SaveChanges();
        }
        public void Add(T obj)
        {
            db.Set<T>().Add(obj);
            db.SaveChanges();

        }
        public void Update(T obj)
        {
            db.SaveChanges();
        }
    }
}
