using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CCPerform.Core.Abstract
{
    public interface IBaseRepository<T> where T : class, IEntity, new()
    {
        //Add - Edit - Remove
        bool Add(T item);
        bool Edit(T item);
        bool Remove(T item);

        //List Active
        List<T> GetActive();

        //General List
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression);
        List<T> GetBy(Expression<Func<T, bool>> expression);

        //Id Choise vb.
        T GetByFilter(Expression<Func<T, bool>> expression);

        //
        int Save();
    }
}
