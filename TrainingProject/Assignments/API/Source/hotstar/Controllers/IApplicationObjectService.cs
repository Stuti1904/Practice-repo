using hotstar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotstar.Controllers
{
   public interface IApplicationObjectService: IRepository<Models.Object>
    {
    }

    public class ApplicationObjectService: Repository<Models.Object>, IApplicationObjectService
    {
        public ApplicationObjectService(hotstar2445stutiContext context) : base(context)
        {

        }
        public List<Models.Object> Get()
        {
            var us = base.GetAll();
            return us;
        }
    }
}
