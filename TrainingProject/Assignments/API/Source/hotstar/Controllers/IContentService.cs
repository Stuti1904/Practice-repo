using hotstar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotstar.Controllers
{
   public  interface IContentService: IRepository<Content>
    {
        Content Add(Content content);
        Content Update(int id, Content content);

        Content Getonecontent(string name);
        int UpdateLikes(int id);
        int UpdateDisLikes(int id);
        int UpdateViews(int id);

    }

    public class ContentService: Repository<Content>, IContentService
    {
        private hotstar2445stutiContext context { get; set; }
        public ContentService(hotstar2445stutiContext context): base(context)
        {
            this.context = new hotstar2445stutiContext();
        }

        public Content Add(Content content)
        {
            base.Add(content );
            return content;
        }

        public List<Content> GetContent()
        {
            var con = base.GetAll();
            return con;
        }
        public Content GetContent(int id)
        {
            var onecontent = base.GetOne(id);
            return onecontent;
        }

        public Content Update(int id, Content content)
        {
            var updatedContent = base.GetOne(id);

            updatedContent.Cast = content.Cast;
            updatedContent.Description = content.Description;
            base.update(updatedContent);
            return updatedContent;
        }

        public string Delete(int id)
        {
            base.Delete(id);
            return "DELETED";
        }
        public Content Getonecontent(string name)
        {
            var getone = (from con in context.Contents
                         where con.Title == name
                         select con).FirstOrDefault();
            return getone;
        }
        public int UpdateLikes(int id)
        {
            var getone = base.GetOne(id);
            getone.Likes = getone.Likes + 1;
            base.update(getone);
            return (int)getone.Likes;
           
        }
        public int UpdateDisLikes(int id)
        {
            var getone = base.GetOne(id);
            getone.Dislikes = getone.Dislikes + 1;
            base.update(getone);
            return (int)getone.Dislikes;

        }
        public int UpdateViews(int id)
        {
            var getone= base.GetOne(id);
            getone.Views = getone.Views + 1;
            base.update(getone);
            return (int)getone.Views;
        }
    }
}
