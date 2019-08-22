using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserRepository: BaseRepository<Users>
    {

        public Users Insert(Users entity)
        {
            Users result = new Users();
            myShopEntities db = new myShopEntities();
            result=db.Users.Add(entity);
            db.SaveChanges();
            return result;
        }

        public Users Update(Users entity)
        {
            myShopEntities db = new myShopEntities();
            Users defaultUser=db.Users.Where(c => c.Id == entity.Id).FirstOrDefault();
            defaultUser.Password = entity.Password;
            defaultUser.UserName = entity.UserName;
            defaultUser.FullName = entity.FullName;
            defaultUser.Credit = entity.Credit;
            db.SaveChanges();
            return defaultUser;
        }

        public void Delete(int id)
        {
            myShopEntities db = new myShopEntities();

            Users usr=db.Users.Where(c => c.Id == id).FirstOrDefault();
            db.Users.Remove(usr);
            db.SaveChanges();
        }
    }
}
