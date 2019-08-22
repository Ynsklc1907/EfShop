using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class StudentRepository:BaseRepository<Students>
    {
        myShopEntities db = new myShopEntities();
        public void Add(Students entity)
        {
            db.Students.Add(entity);
            db.SaveChanges();
        }

        public void Update(Students entity)
        {
            Students std = new Students();
            std = db.Set<Students>().Where(c => c.Id == entity.Id).FirstOrDefault();
            // cat = db.Categories.Where(c => c.Id == entity.Id).FirstOrDefault();
            std.Name = entity.Name;
            std.SurName = entity.SurName;
            std.Age = entity.Age;
            
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            Students std = new Students();
            std = db.Students.Where(c => c.Id == id).FirstOrDefault();
            db.Students.Remove(std);
            db.SaveChanges();
        }
    }
}
