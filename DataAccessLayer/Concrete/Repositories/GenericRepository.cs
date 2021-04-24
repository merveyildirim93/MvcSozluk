using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<Type> : IRepository<Type> where Type : class
    {

        Context context = new Context();
        DbSet<Type> _object;
        public GenericRepository()
        {
            _object = context.Set<Type>();
        }
        public void Delete(Type type)
        {
            _object.Remove(type);
            context.SaveChanges();
        }

        public void Insert(Type type)
        {
            _object.Add(type);
            context.SaveChanges();
        }

        public List<Type> List()
        {
            return _object.ToList();
        }

        public List<Type> List(Expression<Func<Type, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(Type type)
        {
            context.SaveChanges();
        }
    }
}
