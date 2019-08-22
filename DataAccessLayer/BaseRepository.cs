
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public abstract class BaseRepository<T> where T:class
    {
        public virtual List<T> List()
        {
            var db = new myShopEntities();


            List<T> result = db.Set<T>().ToList();


            return result;
        }

        //public virtual void Add(T entity)
        //{

        //}

        //public virtual void Update(T entity)
        //{

        //}

        //public virtual void Delete(int id)
        //{


        //}

    }
}
