using Mini_Ecommerce.Entities.DTO.Request;
using Mini_Ecommerce.Entities.DTO.Response;
using Mini_Ecommerce.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Core.Interface
{
    public interface ICustomerRepository 
    {
        Task<bool> AddCustomerAsync(Customer model);
        Task<bool> AddOrderAsync(Order model);
        Task<IEnumerable<Customer>> GetCustomersAsync();
        Task<Customer> GetCustomerByIdAsync(int? id);
        Task<Order> GetOrderByIdAsync(string id);
        Task<IEnumerable<Customer>> SearchCustomerByNameAsync(string name);
        Task<Customer> UpdateCustomerAsync(int CustomerId, Customer model);
        Task<Order> UpdateOrderAsync(string OrderId, Order model);
        Task<bool> DeleteCustomerAsync(int CustomerId);

    }
}
