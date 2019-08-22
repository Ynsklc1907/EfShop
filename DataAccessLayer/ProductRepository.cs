using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductRepository : BaseRepository<Products>
    {

        public  void Add(Products entity)
        {
            myShopEntities db = new myShopEntities();
            db.Products.Add(entity);
            db.SaveChanges();
        }

        public  void Update(Products entity)
        {
            myShopEntities db = new myShopEntities();
            var updateEdilecek = db.Set<Products>().Where(c => c.Id == entity.Id).FirstOrDefault();

            updateEdilecek.Name = entity.Name;
            updateEdilecek.Price = entity.Price;
            updateEdilecek.productCode = entity.productCode;
            updateEdilecek.stocks = entity.stocks;
            updateEdilecek.categoryId = entity.categoryId;

            db.SaveChanges();
        }

        public  void Delete(int id)
        {
            myShopEntities db = new myShopEntities();
            var entity = db.Set<Products>().Where(c => c.Id == id).FirstOrDefault();
            db.Set<Products>().Remove(entity);
            db.SaveChanges();
        }
    }
}
