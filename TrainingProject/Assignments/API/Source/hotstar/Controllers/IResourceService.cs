using hotstar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotstar.Controllers
{
     public interface IResourceService : IRepository<Resource>
    {
        Resource Add(Resource resource);
        Resource Update(int id, Resource resource);

    }

    public class ResourceService : Repository<Resource>, IResourceService
    {

        public ResourceService(hotstar2445stutiContext context) : base(context)
        {

        }

        public Resource Add(Resource resource)
        {
            base.Add(resource);
            return resource;
        }

        public List<Resource> GetContent()
        {
            var con = base.GetAll();
            return con;
        }
        public Resource GetContent(int id)
        {
            var oneresource = base.GetOne(id);
            return oneresource;
        }

        public Resource Update(int id, Resource resource)
        {
            var updatedresource = base.GetOne(id);

            updatedresource.Url = resource.Url;
            base.update(updatedresource);
            return updatedresource;
        }

        public string DeleteResource(int id)
        {
            base.Delete(id);
            return "DELETED";
        }

    }
}
