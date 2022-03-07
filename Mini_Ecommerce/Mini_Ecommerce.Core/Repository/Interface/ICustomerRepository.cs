using Mini_Ecommerce.Entities.DTO.Request;
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
        Task<Customer> AddCustomerAsync(CustomerRequestDto customerRequestDto);
        Task<Order> AddOrderAsync(Order order);
    }
}
