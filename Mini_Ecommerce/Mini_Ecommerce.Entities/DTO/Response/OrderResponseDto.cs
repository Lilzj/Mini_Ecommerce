using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Entities.DTO.Response
{
    public class OrderResponseDto
    {
        public string OrderId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateCreated { get; set; }
    }
}