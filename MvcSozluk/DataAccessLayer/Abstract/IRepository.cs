using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<Type>
    {
        List<Type> List();
        void Insert(Type type);
        void Update(Type type);
        void Delete(Type type);

        List<Type> List(Expression<Func<Type, bool>> filter);
    }
}
