using Day14P2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14P2
{
    public class ToyFunction
    {
        public ToyCompanyContext context {get; set;}

        public ToyFunction()
        {
            context = new ToyCompanyContext();
        }

        public async Task<List<Toy>> GetToys()
        {
            var t = await (from te in context.Toys
                           select te).ToListAsync();
            return t;
        }
        public async Task<Toy> SearchToy(int id)
        {
            var t = await (from te in context.Toys
                           where te.ToyId == id
                           select new Toy
                           {
                               ToyId = te.ToyId,
                               ToyName = te.ToyName,
                               Price = te.Price
                           }).SingleAsync();
            return t;
        }
    }
}
