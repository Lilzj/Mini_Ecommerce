using Mini_Ecommerce.Entities.Enum;
using Mini_Ecommerce.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Entities.DTO.Request
{
    public class CustomerUpdateRequestDto
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public IEnumerable<AddressRequestDto> Address { get; set; }
    }
}
