using hotstar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotstar.Controllers
{
    public interface IRoleService : IRepository<Role>
    {
    }

    public class RoleService : Repository<Role>, IRoleService
    {
        public RoleService(hotstar2445stutiContext context) : base(context)
        {

        }

        public List<Role> Get()
        {
            var us = base.GetAll();
            return us;
        }
    }
}
