using hotstar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotstar.Controllers
{
     public interface ICommentService: IRepository<Comment>
    {
        List<Comment> GetComments();
        List<Comment> GetByContentId(int id);

        Comment Add(Comment comment);

    }

    public class CommentService: Repository<Comment>, ICommentService
    {
        private hotstar2445stutiContext Context { get; set; }
        public CommentService(hotstar2445stutiContext context) : base(context)
        {
            this.Context = new hotstar2445stutiContext();
        }

        public List<Comment> GetComments()
        {
            return base.GetAll();
        }
        public List<Comment> GetByContentId(int id)
        {
            var comment = (from c in Context.Comments
                           where c.ContentId == id
                           select c).ToList();
            return comment;
        }
        public Comment Add(Comment comment)
        {
            return base.Add(comment);
        }
    }
}
