using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Mini_Ecommerce.Core.Interface;
using Mini_Ecommerce.Data;
using Mini_Ecommerce.Entities.DTO.Request;
using Mini_Ecommerce.Entities.DTO.Response;
using Mini_Ecommerce.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Core.Repository.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Mini_EcommerceContext _ctx;
        private readonly IMapper _map;

        public CustomerRepository(Mini_EcommerceContext ctx, IMapper map)
        {
            _ctx = ctx;
            _map = map;
        }

        private async Task<bool> SavedAsync()
        {
            bool ValueToReturned;
            if (await _ctx.SaveChangesAsync() > 0)
                ValueToReturned = true;
            else
                ValueToReturned = false;

            return ValueToReturned;
        }

        public async Task<bool> AddCustomerAsync(Customer model)
        {
             await _ctx.Customers.AddAsync(model);

            return await SavedAsync();
        }

        public async Task<bool> AddOrderAsync(Order order)
        {

            await _ctx.Orders.AddAsync(order);

            return await SavedAsync();

        }

        public async Task<bool> DeleteCustomerAsync(int? CustomerId)
        {
            var customer = await _ctx.Customers.FirstOrDefaultAsync(x => x.CustomerId == CustomerId);

            if (customer == null)
                return false;
            _ctx.Customers.Remove(customer);

            await _ctx.SaveChangesAsync();
            return true;
        }

        public async Task<Customer> GetCustomerByIdAsync(int? id)
        {
            var customer = await _ctx.Customers
                .Include(x => x.Address)
                .Include(x => x.Orders)
                .FirstOrDefaultAsync(x => x.CustomerId == id);


            return customer;
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _ctx.Customers
                .Include(x => x.Address)
                .Include(x => x.Orders).ToListAsync();
        }

        public async Task<bool> UpdateCustomerAsync(Customer model)
        {
             _ctx.Customers.Update(model);

            return await SavedAsync();
        }

        public Task<bool> UpdateOrderAsync(Order model)
        {
            _ctx.Orders.Update(model);

            return SavedAsync();
        }

        public async Task<IEnumerable<Customer>> SearchCustomerByNameAsync(string name)
        {
            return await _ctx.Customers
                 .Include(x => x.Address)
                 .Include(x => x.Orders)
                 .Where(x => x.Name.ToLower()
                 .Contains(name.ToLower())).ToListAsync();
        }

        public async Task<Order> GetOrderByIdAsync(string id)
        {
            return await _ctx.Orders.FirstOrDefaultAsync(x => x.OrderId == id);
        }
    }
}
