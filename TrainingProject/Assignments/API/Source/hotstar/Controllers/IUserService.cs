using hotstar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotstar.Controllers
{
    public interface IUserService
    {
        List<User> get();
        User Add(User user);
        User Update(int id, User user);
        User Delete(int id);
        User GetByPhone(string phone);
    }
    public class UserService: Repository<User>, IUserService
    {
        private hotstar2445stutiContext context { get; set; }
        public UserService(hotstar2445stutiContext context) : base(context)
        {
            this.context = new hotstar2445stutiContext();
        }

        public User Add(User admin)
        {
            base.Add(admin);
            return admin;
        }

        public List<User> get()
        {
            var ad = base.GetAll();
            return ad;
        }
        public User Update(int id, User user)
        {
            var updatedadmin = base.GetOne(id);

            updatedadmin.Age = user.Age;
            updatedadmin.UserName = user.UserName;
            base.update(updatedadmin);
            return updatedadmin;
        }
        public User Delete(int id)
        {
            return base.Delete(id);
        }
        public User GetByPhone(string phone)
        {
            var tofind = (from us in context.Users
                          where us.Phone == phone
                          select us).FirstOrDefault();
            return tofind;
        }
    }
}
