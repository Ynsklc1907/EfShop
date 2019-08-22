using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoryRepository: BaseRepository<Categories>
    {
        myShopEntities db = new myShopEntities();

        public void Add(Categories entity)
        {            
            db.Categories.Add(entity);
            db.SaveChanges();
        }

        public void Update(Categories entity)
        {
            Categories cat = new Categories();
            cat = db.Set<Categories>().Where(c => c.Id == entity.Id).FirstOrDefault();
           // cat = db.Categories.Where(c => c.Id == entity.Id).FirstOrDefault();
            cat.Name = entity.Name;
            cat.Description = entity.Description;
            cat.CatOrder = entity.CatOrder;
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            Categories cat = new Categories();
            cat = db.Categories.Where(c => c.Id == id).FirstOrDefault();
            db.Categories.Remove(cat);
            db.SaveChanges();
        }
    }
}
