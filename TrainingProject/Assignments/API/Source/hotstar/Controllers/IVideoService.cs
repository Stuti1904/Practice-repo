using hotstar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotstar.Controllers
{
   public  interface IVideoService : IRepository<GeneralInfo>
    {


    }

    public class VideoService: Repository<GeneralInfo>, IVideoService
    {
        public VideoService(hotstar2445stutiContext context): base(context)
        {

        }

        public List<GeneralInfo> GetContent()
        {
            var info = base.GetAll();
            return info;
        }
    }
}
