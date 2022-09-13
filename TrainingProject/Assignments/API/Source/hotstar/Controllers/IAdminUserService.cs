using hotstar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotstar.Controllers
{
    public interface IAdminUserService
    {
        List<AdminUser> getadmin();
        AdminUser Add(AdminUser user);
        AdminUser Update(int id, AdminUser user);
    }

    public class AdminUserService: Repository<AdminUser>, IAdminUserService
    {
        public AdminUserService(hotstar2445stutiContext context) : base(context)
        {

        }
        public AdminUser Add(AdminUser admin)
        {
            base.Add(admin);
            return admin;
        }

        public List<AdminUser> getadmin()
        {
            var ad = base.GetAll();
            return ad;
        }
        public AdminUser Update(int id, AdminUser user)
        {
            var updatedadmin = base.GetOne(id);

            updatedadmin.Age = user.Age;
            updatedadmin.UserName = user.UserName;
            base.update(updatedadmin);
            return updatedadmin;
        }
    }
}
