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
        Task<bool> AddCustomerAsync(CustomerRequestDto customerRequestDto);
        Task<bool> AddOrderAsync(OrderRequestDto order);
        Task<CustomerResponse> GetCustomersAsync();
        Task<CustomerResponse> GetCustomerByNameAsync(string name);
        Task<Customer> UpdateCustomerAsync(int CustomerId, CustomerUpdateRequestDto customerUpdateRequestDto);
        Task<Order> UpdateOrderAsync(string OrderId, OrderUpdateRequestDto orderUpdateRequestDto);
        Task<bool> DeleteCustomerAsync(int CustomerId);

    }
}
