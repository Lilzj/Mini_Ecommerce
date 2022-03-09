using Mini_Ecommerce.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Entities.DTO.Response
{
    public class CustomerResponseDto
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public IEnumerable<AddressResponseDto> Address { get; set; }
        public IEnumerable<OrderResponseDto> Orders { get; set; }
    }
}
