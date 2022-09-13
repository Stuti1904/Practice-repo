using hotstar.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotstar.Controllers
{
   public interface IPlaylistService: IRepository<Playlist>
    {
        List<Playlist> GetAll();
        Playlist Add(Playlist list);
       List< Playlist> GetByUserId(int id);
        Playlist Delete(int id);
    }

    public class PlaylistService: Repository<Playlist>, IPlaylistService
    {
        private hotstar2445stutiContext context { get; set; }
     
        public PlaylistService(hotstar2445stutiContext context) : base(context)
        {
            this.context = new hotstar2445stutiContext();
        
        }
        
        public Playlist Add(Playlist list)
        {
            var us = base.Add(list);
            return us;
        }
        public List<Playlist> GetAll()
        {
            var list = base.GetAll();
            return list;
        }
        public List<Playlist> GetByUserId(int id)
        {
            //var list = (from pl in context.Playlists
            //           where pl.UserId == id
            //           select pl).ToList();

            var list = context.Playlists.Where(x => x.UserId == id).ToList();
            return list;
        }

        public Playlist Delete(int id)
        {
            return base.Delete(id);
        }
    }
}
