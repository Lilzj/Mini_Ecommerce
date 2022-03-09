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

        public async Task<bool> AddCustomerAsync(CustomerRequestDto customerRequestDto)
        {
            var customer = _map.Map<Customer>(customerRequestDto);

             await _ctx.Customers.AddAsync(customer);

            return await SavedAsync();
        }

        public async Task<bool> AddOrderAsync(OrderRequestDto order)
        {
            var Order = _map.Map<Order>(order);

            await _ctx.Orders.AddAsync(Order);

            return await SavedAsync();

        }

        public async Task<bool> DeleteCustomerAsync(int CustomerId)
        {
            var customer = await _ctx.Customers.FirstOrDefaultAsync(x => x.CustomerId == CustomerId);

            if (customer == null)
                return false;
            _ctx.Customers.Remove(customer);

            await _ctx.SaveChangesAsync();
            return true;
        }

        public async Task<CustomerResponse> GetCustomerByNameAsync(string name)
        {
            var customer = await _ctx.Customers
                .Include(x => x.Address)
                .Include(x => x.Orders)
                .FirstOrDefaultAsync(x => x.Name == name);

            var customerResponse =  _map.Map<CustomerResponse>(customer);

            return customerResponse;
        }

        public Task<CustomerResponse> GetCustomersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> UpdateCustomerAsync(int CustomerId, CustomerUpdateRequestDto customerUpdateRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task<Order> UpdateOrderAsync(string OrderId, OrderUpdateRequestDto orderUpdateRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
