using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Entities.DTO.Response
{
    public class OrderDto
    {
        public IEnumerable<OrderResponseDto> Order { get; set; }
    }
}
