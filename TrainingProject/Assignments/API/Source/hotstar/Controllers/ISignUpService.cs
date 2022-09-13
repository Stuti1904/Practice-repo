using hotstar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotstar.Controllers
{
   public  interface ISignUpService : IRepository<User>
    {
    }

    public class SignUpService: Repository<User>, ISignUpService
    {
        public SignUpService(hotstar2445stutiContext context) : base(context)
        {
            
        }

        public  User Add(User user)
        {
            var us = base.Add(user);
            return us;
        }
    }
}
