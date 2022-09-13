using Day14P2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14P2
{
    public class CustomerFunction
    {

public ToyCompanyContext context { get; set; }
        public CustomerFunction()
        {
            context = new ToyCompanyContext();
        }
        public async Task<List<Customer>> GetCustomers()
        {
            var cu = await (from c in context.Customers
                            select new Customer
                            {
                                CustomerId = c.CustomerId,
                                CustomerName = c.CustomerName,
                                Gender = c.Gender
                            }).ToListAsync();
            return cu;
        }
        public async Task<Customer> GetCustomer(int id)
        {
            var cu = await (from c in context.Customers
                            where c.CustomerId == id
                            select c).SingleAsync();
            return cu;
        }
        public async Task<int> AddCustomer(Customer customer)
        {
            context.Add(customer);
            await context.SaveChangesAsync();
            return customer.CustomerId;
        }

      public async Task<string> UpdateCustomer(int id, Customer changedcustomer)
        {
            var c = await GetCustomer(id);
            c.CustomerName = changedcustomer.CustomerName;
            c.Gender = changedcustomer.Gender;
            context.Update(c);
            await context.SaveChangesAsync();
            return "CUSTOMER IS UPDATED";
        }

        public async Task<String> DeleteCustomer(int id)
        {
            var todelete = await GetCustomer(id);
            context.Customers.Remove(todelete);
           await  context.SaveChangesAsync();
            return "DATA DELETED";
        }
    }
}
