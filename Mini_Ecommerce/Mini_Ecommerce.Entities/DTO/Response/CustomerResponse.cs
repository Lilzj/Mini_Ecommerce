using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Entities.DTO.Response
{
    public class CustomerResponse
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public byte Gender { get; set; }
        public int Age { get; set; }
        public IEnumerable<AddressResponseDto> Address { get; set; }
        public IEnumerable<OrderDto> Orders { get; set; }
    }
}
