using Day14P2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14P2
{
    public class OrderFunction
    {
        public ToyCompanyContext context { get; set; }

        public OrderFunction()
        {
            context = new ToyCompanyContext();
        }

        public async Task<List<Order>> GetOrders()
        {
            var or = await (from ord in context.Orders
                           select ord).ToListAsync();
            return or;
        }
        public async Task<string> AddOrder(Order order)
        {
            context.Add(order);
            await context.SaveChangesAsync();
            return "ORDER PLACED";
        }
    }
}
